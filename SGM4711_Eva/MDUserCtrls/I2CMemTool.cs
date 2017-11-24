using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MD.MDCommon;
using DMCommunication;

namespace SGM4711_Eva.MDUserCtrls
{
    public partial class I2CMemTool : UserControl
    {
        RegisterMap regMap;
        DMDongle myDongle;
        IRegOperation myRegOp;
        byte startAddr = 0;
        byte rwCount = 4;
        public I2CMemTool(RegisterMap _regMap, DMDongle _dongle, IRegOperation _myRegOp)
        {
            InitializeComponent();
            this.regMap = _regMap;
            this.myDongle = _dongle;
            this.myRegOp = _myRegOp;
        }

        public void UpdateRegMap(RegisterMap _regmap)
        {
            this.regMap = _regmap;
            this.txt_Display.Clear();
        }

        //private bool RegRead(byte _regAddr, byte[] regData)
        //{
        //    if (myDongle.IsOpen)
        //    {
        //        if (myDongle.readRegBurst(_regAddr, regData, regData.Length))
        //        {
        //            return true;
        //        }
        //    }

        //    MessageBox.Show("Read Register 0x" + _regAddr.ToString("X2") + " Failed!", "Warning");
        //    return false;
        //}

        //private bool RegWrite(byte _regAddr, byte[] regData)
        //{
        //    if (myDongle.IsOpen)
        //    {
        //        if (myDongle.writeRegBurst(_regAddr, regData, regData.Length))
        //        {
        //            return true;
        //        }
        //    }

        //    MessageBox.Show("Write Register 0x" + _regAddr.ToString("X2") + " Failed!", "Warning");
        //    return false;
        //}

        private void numUP_I2CAddr_ValueChanged(object sender, EventArgs e)
        {
            this.startAddr = (byte)numUP_I2CAddr.Value;
            //this.numUP_RWCount.Maximum = 255 - startAddr;
        }

        private void numUP_RWCount_ValueChanged(object sender, EventArgs e)
        {
            this.rwCount = (byte)numUP_RWCount.Value;
        }

        StringBuilder outputString = new StringBuilder(400);
        private void btn_Read_Click(object sender, EventArgs e)
        {
            if (regMap == null)
            {
                MessageBox.Show("Pease open excel/proj file first");
                return;
            }

            outputString.Clear();
            //outputString.AppendLine("All register value in hexadecimal format");
            //outputString.AppendLine();
            if (myDongle.IsOpen)
            {
                #region Count is how many registers
                //byte currentRegAddr = startAddr;
                //int finishCount = 0;
                //byte[] regData;
                //while (currentRegAddr <= 0xFF && finishCount < rwCount)
                //{
                //    if (regMap.Contain(currentRegAddr))
                //    {
                //        //currentReg = regMap[currentRegAddr];
                //        regData = new byte[regMap[currentRegAddr].ByteCount];
                //        if (RegRead(currentRegAddr, regData))
                //        {
                //            // print read back register infomation
                //            for (int ixByteCount = 0; ixByteCount < regData.Length; )
                //            {
                //                //outputString.Append(tempReg.ByteValue[ixByteCount].ToString("X2"));
                //                outputString.Append(String.Format("{0}", regData[ixByteCount].ToString("X2")));
                //                if (++ixByteCount < regData.Length)
                //                    outputString.Append("-");
                //            }
                //            outputString.Append("\r\n");
                //            //outputString.Append("\r\n");
                //            finishCount++;
                //        }
                //        else
                //        {
                //            MessageBox.Show(String.Format("No.{0} Register 0x{1} read failed!", finishCount, currentRegAddr));
                //            break;
                //        }
                //    }
                //    currentRegAddr++;
                //}
                #endregion

                #region Count is how many bytes
                byte[] regData = new byte[rwCount];

                if (myRegOp.RegRead(startAddr, regData, true))
                {
                    // print read back register infomation
                    for (int ixByteCount = 0; ixByteCount < regData.Length; )
                    {
                        outputString.Append(String.Format("{0}", regData[ixByteCount].ToString("X2")));
                        if (++ixByteCount % 10 == 0)
                            outputString.Append("\r\n");
                        else if (ixByteCount < regData.Length)
                            outputString.Append("-");
                    }
                }
                else
                {
                    outputString.Append(String.Format("/* Read failed! */"));
                }
                #endregion 
            }
            else
            {
                outputString.Append(String.Format("/* Can't find Dongle! */"));
            }
            this.txt_Display.Text = outputString.ToString();
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            if (regMap == null)
            {
                MessageBox.Show("Pease open excel/proj file first");
                return;
            }

            if (myDongle.IsOpen)
            {
                #region Count is how many registers
                //string[] tempValues = this.txt_Display.Text.Split(new string[] { "-", "\t", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                //byte[] wrValues = new byte[tempValues.Length];
                //byte tempValue;
                //for (int ix = 0; ix < tempValues.Length; ix++)
                //{
                //    if (byte.TryParse(tempValues[ix], System.Globalization.NumberStyles.HexNumber, null, out tempValue))
                //        wrValues[ix] = tempValue;
                //    else
                //        MessageBox.Show("One or more data wrong");
                //}

                //byte currentRegAddr = startAddr;
                //int finishCount = 0;
                //int ix_bytes = 0;
                //byte[] regData;
                //int bytesCount = 0;
                //while (currentRegAddr <= 0xFF && finishCount < rwCount && ix_bytes < wrValues.Length)
                //{
                //    if (regMap.Contain(currentRegAddr))
                //    {
                //        //currentReg = regMap[currentRegAddr];
                //        bytesCount = regMap[currentRegAddr].ByteCount;
                //        regData = new byte[bytesCount];
                //        for (int ix = 0; ix < bytesCount && ix_bytes < wrValues.Length; ix++)
                //        {
                //            regData[ix] = wrValues[ix_bytes++];
                //        }

                //        if (RegWrite(currentRegAddr, regData))
                //        {
                //            finishCount++;                            
                //        }
                //        else
                //        {
                //            break;
                //        }
                //    }
                //    currentRegAddr++;
                //}
                #endregion 

                #region Count is how many bytes
                //this.txt_Display.Text.Split(new string[] { "-", " ", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                string log = "";
                string[] tempStrings = this.txt_Display.Text.Split(new string[] {"\r\n" }, StringSplitOptions.None);
                //byte[] wrValues = new byte[tempValues.Length];
                List<byte> wrValuesList = new List<byte> { };
                wrValuesList.Clear();
                byte tempValue;
                string[] tempDatas;
                for (int ix = 0; ix < tempStrings.Length; ix++)
                {
                    if (tempStrings[ix].StartsWith("/*") || tempStrings[ix] == null || tempStrings[ix] == "")
                        continue;

                    log = "";
                    tempDatas = tempStrings[ix].Split(new string[] { "-", " " }, StringSplitOptions.RemoveEmptyEntries);
                    for (int ix_byte = 0; ix_byte < tempDatas.Length; ix_byte++)
                    {
                        if (byte.TryParse(tempDatas[ix_byte], System.Globalization.NumberStyles.HexNumber, null, out tempValue))
                            wrValuesList.Add(tempValue);
                        else
                            log += String.Format("\"{0}\"", tempDatas[ix_byte]);
                    }
                    if (log != "")
                    {
                        MessageBox.Show(String.Format("Line {0} has some wrong data: {1}", ix + 1, log));
                        return;
                    }
                }

                // Real Count is the smaller one of count value in GUI and real data count                
                int realCount = wrValuesList.Count <= rwCount ? wrValuesList.Count: rwCount;
                byte[] wrValues;// = new byte[realCount];
                if (realCount <= rwCount)
                {
                    wrValues = wrValuesList.ToArray();
                }
                else
                {
                    wrValues = new byte[rwCount];
                    Array.Copy(wrValuesList.ToArray(), 0, wrValues, 0, wrValues.Length);
                }

                if (myRegOp.RegWrite(startAddr, wrValues, true))
                {
                    //MessageBox.Show(String.Format("{0} bytes have been written.", realCount));
                }
                else
                {
                    //MessageBox.Show("Write Failed!");
                }
                #endregion 
            }
            else
            {
                MessageBox.Show("Can't find Dongle");
            }
        }

        private void UpdateRegMap(string wrString)
        {
 
        }

    }
}
