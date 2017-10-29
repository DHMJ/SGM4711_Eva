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

            Register tempReg;
            outputString.Clear();
            //outputString.AppendLine("All register value in hexadecimal format");
            //outputString.AppendLine();
            if (myDongle.IsOpen)
            {
                for (int ix = 0; ix < rwCount; ix++)
                {
                    tempReg = regMap[(byte)(startAddr + ix)];
                    myDongle.readRegBurst(tempReg.RegAddress, tempReg.ByteValue, tempReg.ByteCount);
                    for (int ixByteCount = 0; ixByteCount < tempReg.ByteCount; ixByteCount++)
                    {
                        //outputString.Append(tempReg.ByteValue[ixByteCount].ToString("X2"));
                        outputString.Append(String.Format("/t{0}", tempReg.ByteValue[ixByteCount].ToString("X2")));
                    }
                    outputString.Append("/r/n");
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
                //string[] tempValues = this.txt_Display.Text.Split(new string[]{"/r/n"},StringSplitOptions.RemoveEmptyEntries);
                string[] tempValues = this.txt_Display.Text.Split(new string[] { "/t", "/r/n" }, StringSplitOptions.RemoveEmptyEntries);
                byte[] wrValues = new byte[tempValues.Length];
                byte tempValue;
                for (int ix = 0; ix < tempValues.Length; ix++)
                {
                    if (byte.TryParse(tempValues[ix], out tempValue))
                        wrValues[ix] = tempValue;
                    else
                        MessageBox.Show("One or more data is wrong");
                }

                myDongle.writeRegBurst(startAddr, wrValues, wrValues.Length);
            }
        }

        private void UpdateRegMap(string wrString)
        {
 
        }

    }
}
