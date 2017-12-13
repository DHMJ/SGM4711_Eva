using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;

namespace DMCommunication
{
    public class DMDongle
    {
        //public variables
        public bool IsOpen = false;

        public enum VCPGROUP
        {
            BASE    = 0x00,
            GPIO    = 0x10,
            SC      = 0x20,
            ADC     = 0x30,
            OWCI    = 0x40,
            I2C     = 0x50,
            SPI     = 0x60   
        };
        public enum USERIOGROUP
        {
            GROUP_A = 0x00,
            GROUP_B = 0x10,
            GROUP_C = 0x20,
            GROUP_D = 0x30,
            GROUP_E = 0x40
        };
        public enum USERIOPIN
        {
            USR_IO_0 = 0x01,
            USR_IO_1 = 0x02,
            USR_IO_2 = 0x04,
            USR_IO_3 = 0x08,
            USR_IO_4 = 0x10,
            USR_IO_5 = 0x20,
            USR_IO_6 = 0x40,
            USR_IO_7 = 0x80
        }

        //private variables
        private byte DevAddr;
        private byte Pilot;
        private byte commMode;
        private int DelayBeforeRead = 400;

        private SerialPort uart = new SerialPort();

        //----------------------DONGLE FUNCTIONS--------------------------------
        public bool dongleInit(string portname, VCPGROUP vg, byte devaddr, byte pilot)
        {
            if (IsOpen)
            {
                dongleDeInit();
            }
            
            uart.PortName = portname;
            uart.BaudRate = 9600;
            uart.DataBits = 8;
            uart.Parity = Parity.None;
            uart.StopBits = StopBits.One;

            //uart.Handshake = Handshake.None;

            try
            {
                uart.Open();
                IsOpen = true;
                //uart.DiscardInBuffer();
                commInit(vg, devaddr, pilot);
                //return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            
            return true;
        }

        public void dongleDeInit()
        {
            uart.Close();
            IsOpen = false;
        }

        //----------------------DUT CTL METHOD  FUNCTIONS-----------------------
        public bool commInit(VCPGROUP vg, byte devaddr, byte pilot)
        {
            if (vg == VCPGROUP.SC)
                commMode = (byte)VCPGROUP.SC;
            else if (vg == VCPGROUP.OWCI)
                commMode = (byte)VCPGROUP.OWCI;
            else if (vg == VCPGROUP.I2C)
                commMode = (byte)VCPGROUP.I2C;
            else if (vg == VCPGROUP.SPI)
                commMode = (byte)VCPGROUP.SPI;
            else
                return false;

            DevAddr = devaddr;
            Pilot = pilot;
            byte[] WriteBuf = new byte[5];

            WriteBuf[0] = 0x5A;
            WriteBuf[1] = 0x05;
            WriteBuf[2] = (byte)commMode;
            WriteBuf[3] = 0x06;
            WriteBuf[4] = DevAddr;

            uart.DiscardInBuffer();

            uart.Write(WriteBuf, 0, 5);

            uint timeOutCounter = 100;
            //while (uart.BytesToRead == 0 && timeOutCounter > 0)
            //{
            //    timeOutCounter--;
                System.Threading.Thread.Sleep(DelayBeforeRead);
            //}

            if (timeOutCounter != 0)
            {
                byte[] readBuf = new byte[uart.BytesToRead];
                uart.Read(readBuf, 0, uart.BytesToRead);
                if (readBuf[0] != 0xA5 || readBuf[1] != 0x05 || readBuf[2] != (byte)commMode || readBuf[3] != 0x06 || readBuf[4] != 0xCC)
                    return false;
            }
            else
                return false;

            //WriteBuf[0] = 0x5A;
            //WriteBuf[1] = 0x05;
            //WriteBuf[2] = (byte)commMode;
            //WriteBuf[3] = 0x05;
            //WriteBuf[4] = Pilot;

            //uart.DiscardInBuffer();
            //uart.Write(WriteBuf, 0, 5);

            //timeOutCounter = 200;
            //while (uart.BytesToRead == 0 && timeOutCounter > 0)
            //{
            //    timeOutCounter--;
            //    System.Threading.Thread.Sleep(10);
            //}

            //if (timeOutCounter != 0)
            //{
            //    byte[] readBuf = new byte[uart.BytesToRead];
            //    uart.Read(readBuf, 0, uart.BytesToRead);
            //    if (readBuf[0] != 0xA5 || readBuf[1] != 0x05 || readBuf[2] != (byte)commMode || readBuf[3] != 0x05 || readBuf[4] != 0xCC)
            //        return false;
            //}
            //else
            //    return false;

            return true;
        }

        public bool writeRegSingle(byte regAddr, byte regData)
        {
            return writeRegBlockSingle(new byte[] { regAddr, regData }, 0x1);
        }

        public bool writeRegBlockSingle(byte[] data, int count)
        {
            byte[] buf = new byte[count * 2 + 5];
            buf[0] = 0x5A;
            buf[1] = Convert.ToByte(count * 2 + 5);
            buf[2] = commMode;
            buf[3] = 0x01;         //writesingle
            buf[4] = (byte)count;      //reg addr
            int returnCount = 5;

            for (byte i = 0; i < count; i++)
            {
                buf[5 + i*2] = data[i*2 + 0];         //length = 1
                buf[6 + i*2] = data[i*2 + 1];      //reg value
            }

            uart.DiscardInBuffer();

            uart.Write(buf, 0, count * 2 + 5);

            //System.Threading.Thread.Sleep(300);

            //uint timeOutCounter = 100;
            //while (uart.BytesToRead == 0 && timeOutCounter > 0)
            //while (uart.BytesToRead < 5 && timeOutCounter > 0)
            //{
            //    timeOutCounter--;
            //    System.Threading.Thread.Sleep(10);

            while (uart.BytesToRead < returnCount)
            { ; }

            //}

            //if (timeOutCounter != 0)
            {
                byte[] readBuf = new byte[returnCount];
                uart.Read(readBuf, 0, returnCount);

                if (readBuf[0] != 0xA5 || readBuf[1] != Convert.ToByte(count * 2 + 5) || readBuf[2] != (byte)commMode || readBuf[3] != 0x01 || readBuf[4] != 0xCC)
                    return false;
            }
            //else
            //    return false;

            return true;
        }

        //********************************************************
        //new for inprove IIC operation speed
        //ack = True, handshake with dongle
        //ack = False, NO handshake with dongle
        //********************************************************
        public bool writeRegBlockSingle(byte[] data, int count, bool ack)
        {
            byte[] buf = new byte[count * 2 + 5];
            buf[0] = 0x5A;
            buf[1] = Convert.ToByte(count * 2 + 5);
            buf[2] = commMode;
            buf[3] = 0x01;         //writesingle
            buf[4] = (byte)count;      //reg addr
            int returnCount = 5;

            for (byte i = 0; i < count; i++)
            {
                buf[5 + i * 2] = data[i * 2 + 0];         //length = 1
                buf[6 + i * 2] = data[i * 2 + 1];      //reg value
            }

            uart.DiscardInBuffer();

            uart.Write(buf, 0, count * 2 + 5);

            //System.Threading.Thread.Sleep(300);

            uint timeOutCounter = 2000;
            //while (uart.BytesToRead == 0 && timeOutCounter > 0)
            //while (uart.BytesToRead < 5 && timeOutCounter > 0)
            //{
            //    timeOutCounter--;
            //    System.Threading.Thread.Sleep(10);
            if (ack)
            {

                //while (uart.BytesToRead < returnCount)
                //{ ; }

                while (uart.BytesToRead < returnCount && timeOutCounter > 0)
                {
                    timeOutCounter--;
                    Thread.Sleep(1);
                }

                if (timeOutCounter != 0)
                {
                    byte[] readBuf = new byte[returnCount];
                    uart.Read(readBuf, 0, returnCount);

                    if (readBuf[0] != 0xA5 || readBuf[1] != Convert.ToByte(count * 2 + 5) || readBuf[2] != (byte)commMode || readBuf[3] != 0x01 || readBuf[4] != 0xCC)
                        return false;
                }
                else
                    return false;
            }
            

            return true;
        }

        public bool readRegSingle(byte regAddr, out byte regData)
        {
            byte[] boockData = new byte[1];
            regData = 0;
            //uart.DiscardInBuffer();
            bool ret = readRegBlockSingle(new byte[] { regAddr }, boockData, 1);
            if(ret == true)
                regData = boockData[0];

            return ret;
        }

        public bool readRegBlockSingle(byte[] addr, byte[] data, int count)
        {
            byte[] buf = new byte[5 + count];
            buf[0] = 0x5A;
            buf[1] = Convert.ToByte(5 + count);
            buf[2] = commMode;
            buf[3] = 0x02;
            buf[4] = (byte)count;
            for(byte i = 0; i < count; i++)
                buf[5 + i] = addr[i];
            //buf[5] = regaddr;

            int returnCount = 5 + count;

            uart.DiscardInBuffer();
            System.Threading.Thread.Sleep(10);
            uart.Write(buf, 0, 5 + count);

            //uint timeOutCounter = 200;
            //while (uart.BytesToRead == 0 && timeOutCounter > 0)
            //{
            //    timeOutCounter--;
            //    System.Threading.Thread.Sleep(DelayBeforeRead + 100);
            //}
            while (uart.BytesToRead < returnCount)
            { ; }

            //if (timeOutCounter != 0 && uart.BytesToRead != 0)
            {
                byte[] readBuf = new byte[uart.BytesToRead];
                uart.Read(readBuf, 0, uart.BytesToRead);
                if (readBuf[0] != 0xA5 || readBuf[1] != Convert.ToByte(5 + count) || readBuf[2] != (byte)commMode || readBuf[3] != 0x02 || readBuf[4] != (byte)count)
                    return false;
                else
                {
                    for (int i = 0; i < count; i++)
                        data[i] = readBuf[i + 5];
                    return true;
                }
            }
            //else
            //    return false;
        }

        //********************************************************
        //new for inprove IIC operation speed
        //ack = True, handshake with dongle
        //ack = False, NO handshake with dongle
        //********************************************************
        public bool writeRegBurst(byte startregaddr, byte[] data, int count, bool ack)
        {
            byte[] buf = new byte[6 + count];
            buf[0] = 0x5A;
            buf[1] = Convert.ToByte(6 + count);
            buf[2] = commMode;
            buf[3] = 0x03;
            buf[4] = (byte)count;
            buf[5] = startregaddr;

            int returnCount = 5;

            for (int i = 0; i < count; i++)
                buf[6 + i] = data[i];

            uart.DiscardInBuffer();
            uart.Write(buf, 0, 6 + count);

            uint timeOutCounter = 2000;

            if (ack)
            {

                while (uart.BytesToRead < returnCount && timeOutCounter > 0)
                {
                    timeOutCounter--;
                    Thread.Sleep(1); 
                }

                if (timeOutCounter != 0)
                {
                    byte[] readBuf = new byte[returnCount];
                    uart.Read(readBuf, 0, returnCount);
                    if (readBuf[0] != 0xA5 || readBuf[1] != Convert.ToByte(6 + count) || readBuf[2] != (byte)commMode || readBuf[3] != 0x03 || readBuf[4] != 0xCC)
                        return false;
                }
                else
                    return false;
            }

            return true;
        }

        public bool writeRegBurst(byte startregaddr, byte[] data, int count)
        {
            byte[] buf = new byte[6 + count];
            buf[0] = 0x5A;
            buf[1] = Convert.ToByte(6 + count);
            buf[2] = commMode;
            buf[3] = 0x03;
            buf[4] = (byte)count;
            buf[5] = startregaddr;

            int returnCount = 5;

            for (int i = 0; i < count; i++)
                buf[6 + i] = data[i];

            uart.DiscardInBuffer();
            uart.Write(buf, 0, 6 + count);

            //uint timeOutCounter = 200;

            while (uart.BytesToRead < returnCount)
            { ; }
            //}

            //if (timeOutCounter != 0)
            {
                byte[] readBuf = new byte[returnCount];
                uart.Read(readBuf, 0, returnCount);
                if (readBuf[0] != 0xA5 || readBuf[1] != Convert.ToByte(6 + count) || readBuf[2] != (byte)commMode || readBuf[3] != 0x03 || readBuf[4] != 0xCC)
                    return false;
            }
            //else
            //    return false;

            return true;
        }

        public bool readRegBurst(byte startregaddr, byte[] data, int count)
        {
            byte[] buf = new byte[6];
            buf[0] = 0x5A;
            buf[1] = 0x06;
            buf[2] = commMode;
            buf[3] = 0x04;
            buf[4] = (byte)count;
            buf[5] = startregaddr;

            int returnCount = count + 4;

            uart.DiscardInBuffer();
            uart.Write(buf, 0, 6);

            //uint timeOutCounter = 200;
            //while (uart.BytesToRead == 0 && timeOutCounter > 0)
            //{
            //    timeOutCounter--;
                //System.Threading.Thread.Sleep(DelayBeforeRead + 100);
            //}

            //int validData = 0;
            //if (count > (byte)(uart.BytesToRead))
            //    validData = uart.BytesToRead;
            //else
             //   validData = count + 4;

                while (uart.BytesToRead < returnCount)
                { ; }

            //if (timeOutCounter != 0 && uart.BytesToRead != 0)
            {
                byte[] readBuf = new byte[returnCount];
                uart.Read(readBuf, 0, returnCount);

                //byte[] readBuf = new byte[uart.BytesToRead];
                //uart.Read(readBuf, 0, uart.BytesToRead);
                if (readBuf[0] != 0xA5 || readBuf[1] != 0x06 || readBuf[2] != (byte)commMode || readBuf[3] != 0x04)
                    return false;
                else
                {
                    for (int i = 0; i < count; i++)
                        data[i] = readBuf[i + 4];
                    return true;
                }
            }
            //else
            //    return false;
        }

        //----------------------USER IO FUNCTIONS--------------------------------
        public bool setUserIO(USERIOGROUP group, USERIOPIN pin )
        {
            byte[] buf = new byte[6];
            buf[0] = 0x5A;
            buf[1] = 0x05;
            buf[2] = (byte)VCPGROUP.GPIO;
            buf[3] = 0x01;              //set io
            buf[4] = (byte)pin;         //pin
            uart.Write(buf, 0, 5);


            uint timeOutCounter = 200;
            //while (uart.BytesToRead == 0 && timeOutCounter > 0)
            //{
            //    timeOutCounter--;
            System.Threading.Thread.Sleep(DelayBeforeRead);
            //}

            if (timeOutCounter != 0)
            {
                byte[] readBuf = new byte[uart.BytesToRead];
                uart.Read(readBuf, 0, uart.BytesToRead);
                if (readBuf[0] != 0xA5 || readBuf[1] != 0x05 || readBuf[2] != (byte)VCPGROUP.GPIO || readBuf[3] != 0x01 || readBuf[4] != 0xCC)
                    return false;
            }
            else
                return false;

            return true;
        }

        public bool resetUserIO( USERIOGROUP group, USERIOPIN pin )
        {
            byte[] buf = new byte[6];
            buf[0] = 0x5A;
            buf[1] = 0x05;
            buf[2] = (byte)VCPGROUP.GPIO;
            buf[3] = 0x02;              //reset io
            buf[4] = (byte)pin;         //pin
            uart.Write(buf, 0, 5);

            uint timeOutCounter = 200;
            //while (uart.BytesToRead == 0 && timeOutCounter > 0)
            //{
            //    timeOutCounter--;
            System.Threading.Thread.Sleep(DelayBeforeRead);
            //}

            if (timeOutCounter != 0)
            {
                byte[] readBuf = new byte[uart.BytesToRead];
                uart.Read(readBuf, 0, uart.BytesToRead);
                if (readBuf[0] != 0xA5 || readBuf[1] != 0x05 || readBuf[2] != (byte)VCPGROUP.GPIO || readBuf[3] != 0x02 || readBuf[4] != 0xCC)
                    return false;
            }
            else
                return false;

            return true;
        }

        public bool toggleUserIO(USERIOGROUP group, USERIOPIN pin)
        {
            byte[] buf = new byte[6];
            buf[0] = 0x5A;
            buf[1] = 0x05;
            buf[2] = (byte)VCPGROUP.GPIO;
            buf[3] = 0x03;         //toggle io
            buf[4] = (byte)pin;         //pin
            uart.Write(buf, 0, 5);

            uint timeOutCounter = 200;
            //while (uart.BytesToRead == 0 && timeOutCounter > 0)
            //{
            //    timeOutCounter--;
            System.Threading.Thread.Sleep(DelayBeforeRead);
            //}

            if (timeOutCounter != 0)
            {
                byte[] readBuf = new byte[uart.BytesToRead];
                uart.Read(readBuf, 0, uart.BytesToRead);
                if (readBuf[0] != 0xA5 || readBuf[1] != 0x05 || readBuf[2] != (byte)VCPGROUP.GPIO || readBuf[3] != 0x03 || readBuf[4] != 0xCC)
                    return false;
            }
            else
                return false;

            return true;
        }

        public byte readUserIO(USERIOGROUP group, USERIOPIN pin)
        {
            byte[] buf = new byte[6];
            buf[0] = 0x5A;
            buf[1] = 0x05;
            buf[2] = (byte)VCPGROUP.GPIO;
            buf[3] = 0x04;         //toggle io
            buf[4] = (byte)pin;         //pin
            uart.Write(buf, 0, 5);

            uint timeOutCounter = 200;
            //while (uart.BytesToRead == 0 && timeOutCounter > 0)
            //{
            //    timeOutCounter--;
            System.Threading.Thread.Sleep(DelayBeforeRead + 100);
            //}

            if (timeOutCounter != 0)
            {
                byte[] readBuf = new byte[uart.BytesToRead];
                uart.Read(readBuf, 0, uart.BytesToRead);
                if (readBuf[0] != 0xA5 || readBuf[1] != 0x05 || readBuf[2] != (byte)VCPGROUP.GPIO || readBuf[3] != 0x04)
                    return 0xFF;
                else
                    return readBuf[4];
            }
            else
                return 0xFF;

            //return readBuf[3];
        }

        //------------------------ADCs FUNCTIONS---------------------------------

    }
}
