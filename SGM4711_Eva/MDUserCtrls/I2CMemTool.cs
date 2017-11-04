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
        byte startAddr = 0;
        byte rwCount = 4;
        public I2CMemTool(RegisterMap _regMap, DMDongle _dongle)
        {
            InitializeComponent();
            this.regMap = _regMap;
            this.myDongle = _dongle;
        }

        private bool RegRead(byte _regAddr, byte[] regData)
        {
            if (myDongle.IsOpen)
            {
                if (myDongle.readRegBurst(_regAddr, regData, regData.Length))
                {
                    return true;
                }
            }

            MessageBox.Show("Read Register 0x" + _regAddr.ToString("X2") + " Failed!", "Warning");
            return false;
        }

        private bool RegWrite(byte _regAddr, byte[] regData)
        {
            if (myDongle.IsOpen)
            {
                if (myDongle.writeRegBurst(_regAddr, regData, regData.Length))
                {
                    return true;
                }
            }

            MessageBox.Show("Write Register 0x" + _regAddr.ToString("X2") + " Failed!", "Warning");
            return true;
        }

        private void numUP_I2CAddr_ValueChanged(object sender, EventArgs e)
        {
            this.startAddr = (byte)numUP_I2CAddr.Value;
            this.numUP_RWCount.Maximum = 255 - startAddr;
        }

        private void numUP_RWCount_ValueChanged(object sender, EventArgs e)
        {
            this.rwCount = (byte)numUP_RWCount.Value;
        }

        StringBuilder outputString = new StringBuilder(400);
        private void btn_Read_Click(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            outputString.Clear();
            //outputString.AppendLine("All register value in hexadecimal format");
            //outputString.AppendLine();
            if (myDongle.IsOpen)
            {
                byte currentRegAddr = startAddr;
                int finishCount = 0;
                byte[] regData;
                while (currentRegAddr <= 0xFF && finishCount < rwCount)
                {
                    if(regMap.Contain(currentRegAddr))
                    {
                        //currentReg = regMap[currentRegAddr];
                        regData = new byte[regMap[currentRegAddr].ByteCount];
                        if (RegRead(currentRegAddr, regData))
                        {
                            // print read back register infomation
                            for (int ixByteCount = 0; ixByteCount < regData.Length; ixByteCount++)
                            {
                                //outputString.Append(tempReg.ByteValue[ixByteCount].ToString("X2"));
                                outputString.Append(String.Format("/t{0}", regData[ixByteCount].ToString("X2")));
                            }
                            outputString.Append("/r/n");
                            finishCount++;
                        }
                        else
                        {
                            MessageBox.Show(String.Format("No.{0} Register 0x{1} read failed!", finishCount, currentRegAddr));
                            break;
                        }
                    }
                    currentRegAddr++;
                }
            }
            this.txt_Display.Text = outputString.ToString();
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            if (myDongle.IsOpen)
            {
                string[] tempValues = this.txt_Display.Text.Split(new string[] { "/t", "/r/n" }, StringSplitOptions.RemoveEmptyEntries);
                byte[] wrValues = new byte[tempValues.Length];
                byte tempValue;
                for (int ix = 0; ix < tempValues.Length; ix++)
                {
                    if (byte.TryParse(tempValues[ix], out tempValue))
                        wrValues[ix] = tempValue;
                    else
                        MessageBox.Show("One or more data wrong");
                }

                byte currentRegAddr = startAddr;
                int finishCount = 0;
                int ix_bytes = 0;
                byte[] regData;
                int bytesCount = 0;
                while (currentRegAddr <= 0xFF && finishCount < rwCount && ix_bytes < wrValues.Length)
                {
                    if (regMap.Contain(currentRegAddr))
                    {
                        //currentReg = regMap[currentRegAddr];
                        bytesCount = regMap[currentRegAddr].ByteCount;
                        regData = new byte[bytesCount];
                        for (int ix = 0; ix < bytesCount && ix_bytes < wrValues.Length; ix++)
                        {
                            regData[ix] = wrValues[ix_bytes++];
                        }

                        if (RegWrite(currentRegAddr, regData))
                        {
                            finishCount++;                            
                        }
                        else
                        {
                            break;
                        }
                    }
                    currentRegAddr++;
                }
            }
        }

        private void UpdateRegMap(string wrString)
        {
 
        }

    }
}
