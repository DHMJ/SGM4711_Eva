using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MD.MDCommon;

namespace SGM4711_Eva.GUI
{
    public partial class OutputMuxForm : Form
    {
        RegisterMap regMap;
        IRegOperation myRegOp;
        int mode;
        public OutputMuxForm()
        {
            InitializeComponent();
        }

        public OutputMuxForm(RegisterMap _regMap,IRegOperation _myRegOp, int modeIndex)
        {
            InitializeComponent();
            this.regMap = _regMap;
            myRegOp = _myRegOp;
            mode = modeIndex;
            InitGUI(modeIndex);
        }

        private void InitGUI(int modeIndex)
        {
            Register tempReg = regMap[0x25];
            
            switch (mode)
            {
                case 0:
                    this.grb_2p0.Visible = true;
                    this.grb_2p1.Visible = false;
                    this.grb_PBTL.Visible = false;
                    this.grb_2p0.Location = new Point(12, 12);
                    this.Size = new Size(this.grb_2p0.Width + 40, this.grb_2p0.Height + 60);
                    this.MaximumSize = this.Size;
                    this.MinimumSize = this.Size;
                    // 2.0  PWM1 3 2 4
                    this.cmb_2p0_Out1.SelectedIndex = GUISetting(0);
                    this.cmb_2p0_Out2.SelectedIndex = GUISetting(2);
                    this.cmb_2p0_Out3.SelectedIndex = GUISetting(1);
                    this.cmb_2p0_Out4.SelectedIndex = GUISetting(3);

                    if (!CheckOutputUnique(cmb_2p0_Out1, cmb_2p0_Out2, cmb_2p0_Out3, cmb_2p0_Out4))
                    {
                        MessageBox.Show("Please make sure all output item is unique and try again!");
                    }

                    break;

                case 1:
                    this.grb_2p0.Visible = false;
                    this.grb_2p1.Visible = true;
                    this.grb_PBTL.Visible = false;
                    this.grb_2p1.Location = new Point(12, 12);
                    this.Size = new Size(this.grb_2p1.Width + 40, this.grb_2p1.Height + 60);
                    this.MaximumSize = this.Size;
                    this.MinimumSize = this.Size;

                    // 2.1 1 2 3 4
                    this.cmb_2p1_Out1.SelectedIndex = GUISetting(0);
                    this.cmb_2p1_Out2.SelectedIndex = GUISetting(1);
                    this.cmb_2p1_Out3.SelectedIndex = GUISetting(2);
                    this.cmb_2p1_Out4.SelectedIndex = GUISetting(3);

                    if (!CheckOutputUnique(cmb_2p1_Out1, cmb_2p1_Out2, cmb_2p1_Out3, cmb_2p1_Out4))
                    {
                        MessageBox.Show("Please make sure all output item is unique and try again!");
                    }

                    break;

                case 2:
                    this.grb_2p0.Visible = false;
                    this.grb_2p1.Visible = false;
                    this.grb_PBTL.Visible = true;
                    this.grb_PBTL.Location = new Point(12, 12);
                    this.Size = new Size(this.grb_PBTL.Width + 40, this.grb_PBTL.Height + 60);
                    this.MaximumSize = this.Size;
                    this.MinimumSize = this.Size;

                    // PBTL 1 1 3 3
                    this.cmb_PBTL_Out1.SelectedIndex = 0;//GUISetting(0);
                    this.cmb_PBTL_Out2.SelectedIndex = 1;//GUISetting(0);
                    this.cmb_PBTL_Out3.SelectedIndex = 2;//GUISetting(2);
                    this.cmb_PBTL_Out4.SelectedIndex = 3;//GUISetting(2);

                    if (!CheckOutputUnique(cmb_PBTL_Out1, cmb_PBTL_Out2, cmb_PBTL_Out3, cmb_PBTL_Out4))
                    {
                        MessageBox.Show("Please make sure all output item is unique and try again!");
                        return;
                    }

                    break;
            }
        }

        private int GUISetting(int chIx)
        {
            int selectIx = 0;
            Register tempReg = regMap[0x25];

            if ((int)tempReg["MUX_TO_OUT_A"].BFValue == chIx)
            {
                selectIx = 0;
            }
            else if ((int)tempReg["MUX_TO_OUT_B"].BFValue == chIx)
                selectIx = 1;
            else if ((int)tempReg["MUX_TO_OUT_C"].BFValue == chIx)
                selectIx = 2;
            else
                selectIx = 3;

            return selectIx;
        }

        private void RegSetting(int outIx, byte value)
        {
            Register tempReg = regMap[0x25];
            // 2.0  PWM 1 3 2 4            
            switch (outIx)
            {
                case 0:
                    tempReg["MUX_TO_OUT_A"].BFValue = value;
                    break;

                case 1:
                    tempReg["MUX_TO_OUT_B"].BFValue = value;
                    break;

                case 2:
                    tempReg["MUX_TO_OUT_C"].BFValue = value;
                    break;

                case 3:
                    tempReg["MUX_TO_OUT_D"].BFValue = value;
                    break;
            }
        }

        /// <summary>
        /// No repeat will reture true, and false if some item is not unique
        /// </summary>
        /// <param name="cmbA"></param>
        /// <param name="cmbB"></param>
        /// <param name="cmbC"></param>
        /// <param name="cmbD"></param>
        /// <returns></returns>
        private bool CheckOutputUnique(ComboBox cmbA, ComboBox cmbB, ComboBox cmbC, ComboBox cmbD)
        {
            bool ret = true;

            if ((cmbA.SelectedIndex == cmbB.SelectedIndex) || (cmbA.SelectedIndex == cmbC.SelectedIndex) || (cmbA.SelectedIndex == cmbD.SelectedIndex)
                || (cmbB.SelectedIndex == cmbC.SelectedIndex) || (cmbB.SelectedIndex == cmbD.SelectedIndex)
                || (cmbC.SelectedIndex == cmbD.SelectedIndex))
            {
                ret = false;
            }

            return ret;
        }

        private void btn_Download_Param_Click(object sender, EventArgs e)
        {
            #region GUI control
            switch (mode)
            {
                case 0:
                    this.grb_2p0.Visible = true;
                    this.grb_2p1.Visible = false;
                    this.grb_PBTL.Visible = false;
                    //this.grb_2p0.Location = new Point(12, 12);
                    //this.Size = new Size(this.grb_2p0.Width + 40, this.grb_2p0.Height + 60);
                    //this.MaximumSize = this.Size;
                    //this.MinimumSize = this.Size;
                    if (!CheckOutputUnique(cmb_2p0_Out1, cmb_2p0_Out2, cmb_2p0_Out3, cmb_2p0_Out4))
                    {
                        MessageBox.Show("Please make sure all output item is unique and try again!");
                        return;
                    }

                    break;

                case 1:
                    this.grb_2p0.Visible = false;
                    this.grb_2p1.Visible = true;
                    this.grb_PBTL.Visible = false;
                    //this.grb_2p1.Location = new Point(12, 12);
                    //this.Size = new Size(this.grb_2p1.Width + 40, this.grb_2p1.Height + 60);
                    //this.MaximumSize = this.Size;
                    //this.MinimumSize = this.Size;

                    if (!CheckOutputUnique(cmb_2p1_Out1, cmb_2p1_Out2, cmb_2p1_Out3, cmb_2p1_Out4))
                    {
                        MessageBox.Show("Please make sure all output item is unique and try again!");
                        return;
                    }

                    break;

                case 2:
                    this.grb_2p0.Visible = false;
                    this.grb_2p1.Visible = false;
                    this.grb_PBTL.Visible = true;
                    //this.grb_PBTL.Location = new Point(12, 12);
                    //this.Size = new Size(this.grb_PBTL.Width + 40, this.grb_PBTL.Height + 60);
                    //this.MaximumSize = this.Size;
                    //this.MinimumSize = this.Size;

                    if (!CheckOutputUnique(cmb_PBTL_Out1, cmb_PBTL_Out2, cmb_PBTL_Out3, cmb_PBTL_Out4))
                    {
                        MessageBox.Show("Please make sure all output item is unique and try again!");
                        return;
                    }

                    break;
            }

            #endregion 

            Register tempReg = regMap[0x25];
            switch (mode)
            {
                case 0:
                    // 2.0  PWM 1 3 2 4
                    RegSetting(this.cmb_2p0_Out1.SelectedIndex, 0x00);
                    RegSetting(this.cmb_2p0_Out2.SelectedIndex, 0x02);
                    RegSetting(this.cmb_2p0_Out3.SelectedIndex, 0x01);
                    RegSetting(this.cmb_2p0_Out4.SelectedIndex, 0x03);                    
                    break;

                case 1:
                    // 2.1 PWM 1 2 3 4
                    RegSetting(this.cmb_2p1_Out1.SelectedIndex, 0x00);
                    RegSetting(this.cmb_2p1_Out2.SelectedIndex, 0x01);
                    RegSetting(this.cmb_2p1_Out3.SelectedIndex, 0x02);
                    RegSetting(this.cmb_2p1_Out4.SelectedIndex, 0x03);
                    break;

                case 2:
                    // PBTL PWM 1 1 3 3
                    RegSetting(this.cmb_PBTL_Out1.SelectedIndex, 0x00);
                    RegSetting(this.cmb_PBTL_Out2.SelectedIndex, 0x00);
                    RegSetting(this.cmb_PBTL_Out3.SelectedIndex, 0x02);
                    RegSetting(this.cmb_PBTL_Out4.SelectedIndex, 0x02);
                    break;
            }

            //Console.WriteLine("Reg25 Reg:" + tempReg.RegValueString);
            //Console.WriteLine("OutA:"+ tempReg.GetBFValue("MUX_TO_OUT_A"));
            //Console.WriteLine("OutB:" + tempReg.GetBFValue("MUX_TO_OUT_B"));
            //Console.WriteLine("OutC:" + tempReg.GetBFValue("MUX_TO_OUT_C"));
            //Console.WriteLine("OutD:" + tempReg.GetBFValue("MUX_TO_OUT_D"));
            myRegOp.RegWrite(0x25);
            myRegOp.UpdateRegSettingSource();
        }
    }
}
