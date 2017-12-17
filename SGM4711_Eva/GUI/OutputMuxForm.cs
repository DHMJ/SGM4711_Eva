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
                    // 2.0 
                    this.cmb_2p0_OutA.SelectedIndex = (int)tempReg["MUX_TO_OUT_A"].BFValue;
                    this.cmb_2p0_OutB.SelectedIndex = (int)tempReg["MUX_TO_OUT_B"].BFValue;
                    this.cmb_2p0_OutC.SelectedIndex = (int)tempReg["MUX_TO_OUT_C"].BFValue;
                    this.cmb_2p0_OutD.SelectedIndex = (int)tempReg["MUX_TO_OUT_D"].BFValue;

                    if (!CheckOutputUnique(cmb_2p0_OutA, cmb_2p0_OutB, cmb_2p0_OutC, cmb_2p0_OutD))
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

                    // 2.1
                    this.cmb_2p1_OutA.SelectedIndex = (int)tempReg["MUX_TO_OUT_A"].BFValue;
                    this.cmb_2p1_OutB.SelectedIndex = (int)tempReg["MUX_TO_OUT_B"].BFValue;
                    this.cmb_2p1_OutC.SelectedIndex = (int)tempReg["MUX_TO_OUT_C"].BFValue;
                    this.cmb_2p1_OutD.SelectedIndex = (int)tempReg["MUX_TO_OUT_D"].BFValue;

                    if (!CheckOutputUnique(cmb_2p1_OutA, cmb_2p1_OutB, cmb_2p1_OutC, cmb_2p1_OutD))
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

                    // PBTL
                    this.cmb_PBTL_OutA.SelectedIndex = (int)tempReg["MUX_TO_OUT_A"].BFValue;
                    this.cmb_PBTL_OutB.SelectedIndex = (int)tempReg["MUX_TO_OUT_B"].BFValue;
                    this.cmb_PBTL_OutC.SelectedIndex = (int)tempReg["MUX_TO_OUT_C"].BFValue;
                    this.cmb_PBTL_OutD.SelectedIndex = (int)tempReg["MUX_TO_OUT_D"].BFValue;

                    if (!CheckOutputUnique(cmb_PBTL_OutA, cmb_PBTL_OutB, cmb_PBTL_OutC, cmb_PBTL_OutD))
                    {
                        MessageBox.Show("Please make sure all output item is unique and try again!");
                        return;
                    }

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
                    if (!CheckOutputUnique(cmb_2p0_OutA, cmb_2p0_OutB, cmb_2p0_OutC, cmb_2p0_OutD))
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

                    if (!CheckOutputUnique(cmb_2p1_OutA, cmb_2p1_OutB, cmb_2p1_OutC, cmb_2p1_OutD))
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

                    if (!CheckOutputUnique(cmb_PBTL_OutA, cmb_PBTL_OutB, cmb_PBTL_OutC, cmb_PBTL_OutD))
                    {
                        MessageBox.Show("Please make sure all output item is unique and try again!");
                        return;
                    }

                    break;
            }

            Register tempReg = regMap[0x25];
            switch (mode)
            {
                case 0:
                    // 2.0  reg25=0x01021345；
                    tempReg["MUX_TO_OUT_A"].BFValue = (byte)this.cmb_2p0_OutA.SelectedIndex;
                    tempReg["MUX_TO_OUT_B"].BFValue = (byte)this.cmb_2p0_OutB.SelectedIndex;
                    tempReg["MUX_TO_OUT_C"].BFValue = (byte)this.cmb_2p0_OutC.SelectedIndex;
                    tempReg["MUX_TO_OUT_D"].BFValue = (byte)this.cmb_2p0_OutD.SelectedIndex;
                    break;

                case 1:
                    // 2.1 reg25=0x01012345；
                    tempReg["MUX_TO_OUT_A"].BFValue = (byte)this.cmb_2p1_OutA.SelectedIndex;
                    tempReg["MUX_TO_OUT_B"].BFValue = (byte)this.cmb_2p1_OutB.SelectedIndex;
                    tempReg["MUX_TO_OUT_C"].BFValue = (byte)this.cmb_2p1_OutC.SelectedIndex;
                    tempReg["MUX_TO_OUT_D"].BFValue = (byte)this.cmb_2p1_OutD.SelectedIndex;
                    break;

                case 2:
                    // PBTL reg25=0x01002245；
                    tempReg["MUX_TO_OUT_A"].BFValue = (byte)this.cmb_PBTL_OutA.SelectedIndex;
                    tempReg["MUX_TO_OUT_B"].BFValue = (byte)this.cmb_PBTL_OutB.SelectedIndex;
                    tempReg["MUX_TO_OUT_C"].BFValue = (byte)this.cmb_PBTL_OutC.SelectedIndex;
                    tempReg["MUX_TO_OUT_D"].BFValue = (byte)this.cmb_PBTL_OutD.SelectedIndex;
                    break;
            }

            myRegOp.RegWrite(0x25);
            myRegOp.UpdateRegSettingSource();
        }
    }
}
