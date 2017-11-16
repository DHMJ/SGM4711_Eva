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
    public partial class Output_Mux : Form
    {
        RegisterMap regMap;
        public Output_Mux()
        {
            InitializeComponent();
            InitGUI(0);
        }

        public Output_Mux(RegisterMap _regMap, int modeIndex)
        {
            InitializeComponent();
            this.regMap = _regMap;
            InitGUI(modeIndex);
        }

        private void InitGUI(int modeIndex)
        {
            //if (regMap == null)
            //{
                // 2.0 
                this.cmb_2p0_LP.SelectedIndex = 0;
                this.cmb_2p0_LN.SelectedIndex = 2;
                this.cmb_2p0_RP.SelectedIndex = 1;
                this.cmb_2p0_RN.SelectedIndex = 3;

                // 2.1
                this.cmb_2p1_LP.SelectedIndex = 0;
                this.cmb_2p1_RP.SelectedIndex = 1;
                this.cmb_2p1_SubP.SelectedIndex = 2;
                this.cmb_2p1_SubN.SelectedIndex = 3;

                // PBTL
                this.cmb_PBTL_LP0.SelectedIndex = 0;
                this.cmb_PBTL_LP1.SelectedIndex = 0;
                this.cmb_PBTL_LN0.SelectedIndex = 2;
                this.cmb_PBTL_LN1.SelectedIndex = 2;
            //}
            //else
            //{
                //Register tempReg = regMap[0x25];
                ////tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_2p0_LP.SelectedIndex;
                ////tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_2p0_LN.SelectedIndex;
                ////tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_2p0_RP.SelectedIndex;
                ////tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_2p0_RN.SelectedIndex;

                //// 2.0  reg25=0x01021345；
                //this.cmb_2p0_LP.SelectedIndex = (int)tempReg["MUX_TO_OUT_A"].BFValue;
                //this.cmb_2p0_LN.SelectedIndex = (int)tempReg["MUX_TO_OUT_B"].BFValue;
                //this.cmb_2p0_RP.SelectedIndex = (int)tempReg["MUX_TO_OUT_C"].BFValue;
                //this.cmb_2p0_RN.SelectedIndex = (int)tempReg["MUX_TO_OUT_D"].BFValue;

                //// 2.1 reg25=0x01012345；
                //this.cmb_2p1_LP.SelectedIndex = (int)tempReg["MUX_TO_OUT_A"].BFValue;
                //this.cmb_2p1_RP.SelectedIndex = (int)tempReg["MUX_TO_OUT_B"].BFValue;
                //this.cmb_2p1_SubP.SelectedIndex = (int)tempReg["MUX_TO_OUT_C"].BFValue;
                //this.cmb_2p1_SubN.SelectedIndex = (int)tempReg["MUX_TO_OUT_D"].BFValue;

                //// PBTL reg25=0x01002245；
                //this.cmb_PBTL_LP0.SelectedIndex = (int)tempReg["MUX_TO_OUT_A"].BFValue;
                //this.cmb_PBTL_LP1.SelectedIndex = (int)tempReg["MUX_TO_OUT_B"].BFValue;
                //this.cmb_PBTL_LN0.SelectedIndex = (int)tempReg["MUX_TO_OUT_C"].BFValue;
                //this.cmb_PBTL_LN1.SelectedIndex = (int)tempReg["MUX_TO_OUT_D"].BFValue;
            //}
            // Enalbe different groupbox
            switch (modeIndex)
            {
                case 0:
                    this.grb_2p0.Enabled = true;
                    this.grb_2p1.Enabled = false;                    
                    this.grb_PBTL.Enabled = false;
                    this.grb_2p0.BackColor = Color.White;
                    this.grb_2p1.BackColor = Color.DarkGray;
                    this.grb_PBTL.BackColor = Color.DarkGray;
                    break;

                case 1:
                    this.grb_2p0.Enabled = false;
                    this.grb_2p1.Enabled = true;
                    this.grb_PBTL.Enabled = false;
                    this.grb_2p0.BackColor = Color.DarkGray;
                    this.grb_2p1.BackColor = Color.White;
                    this.grb_PBTL.BackColor = Color.DarkGray;

                    break;

                case 2:
                    this.grb_2p0.Enabled = false;
                    this.grb_2p1.Enabled = false;
                    this.grb_PBTL.Enabled = true;
                    this.grb_2p0.BackColor = Color.DarkGray;
                    this.grb_2p1.BackColor = Color.DarkGray;
                    this.grb_PBTL.BackColor = Color.White;

                    break;
            }
        }

        /* *******************************************************************
         * Operation Register 0x25
         * BitField: 
         *      MUX_TO_OUT_A
         *      MUX_TO_OUT_B
         *      MUX_TO_OUT_C
         *      MUX_TO_OUT_D
         * *******************************************************************/

        private void btn_CheckSelections_2p0_Click(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_2p0_LP.SelectedIndex;
            tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_2p0_LN.SelectedIndex;
            tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_2p0_RP.SelectedIndex;
            tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_2p0_RN.SelectedIndex;
        }

        private void btn_CheckSelections_2p1_Click(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_2p1_LP.SelectedIndex;
            tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_2p1_RP.SelectedIndex;
            tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_2p1_SubP.SelectedIndex;
            tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_2p1_SubN.SelectedIndex;
        }

        private void btn_CheckSelections_PBTL_Click(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_PBTL_LP0.SelectedIndex;
            tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_PBTL_LP1.SelectedIndex;
            tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_PBTL_LN0.SelectedIndex;
            tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_PBTL_LN1.SelectedIndex;
        }

        #region 2.0
        private void cmb_2p0_LP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_2p0_LP.SelectedIndex;
            //tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_2p0_LN.SelectedIndex;
            //tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_2p0_RP.SelectedIndex;
            //tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_2p0_RN.SelectedIndex;
        }

        private void cmb_2p0_LN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            //tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_2p0_LP.SelectedIndex;
            tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_2p0_LN.SelectedIndex;
            //tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_2p0_RP.SelectedIndex;
            //tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_2p0_RN.SelectedIndex;
        }

        private void cmb_2p0_RP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            //tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_2p0_LP.SelectedIndex;
            //tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_2p0_LN.SelectedIndex;
            tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_2p0_RP.SelectedIndex;
            //tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_2p0_RN.SelectedIndex;
        }

        private void cmb_2p0_RN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            //tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_2p0_LP.SelectedIndex;
            //tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_2p0_LN.SelectedIndex;
            //tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_2p0_RP.SelectedIndex;
            tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_2p0_RN.SelectedIndex;
        }
        #endregion 

        #region 2.1
        private void cmb_2p1_LP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_2p1_LP.SelectedIndex;
            //tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_2p1_RP.SelectedIndex;
            //tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_2p1_SubP.SelectedIndex;
            //tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_2p1_SubN.SelectedIndex;
        }

        private void cmb_2p1_RP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            //tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_2p1_LP.SelectedIndex;
            tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_2p1_RP.SelectedIndex;
            //tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_2p1_SubP.SelectedIndex;
            //tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_2p1_SubN.SelectedIndex;
        }

        private void cmb_2p1_SubP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            //tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_2p1_LP.SelectedIndex;
            //tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_2p1_RP.SelectedIndex;
            tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_2p1_SubP.SelectedIndex;
            //tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_2p1_SubN.SelectedIndex;
        }

        private void cmb_2p1_SubN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            //tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_2p1_LP.SelectedIndex;
            //tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_2p1_RP.SelectedIndex;
            //tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_2p1_SubP.SelectedIndex;
            tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_2p1_SubN.SelectedIndex;
        }
        #endregion 2.1

        private void cmb_PBTL_LP0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_PBTL_LP0.SelectedIndex;
            //tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_PBTL_LP1.SelectedIndex;
            //tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_PBTL_LN0.SelectedIndex;
            //tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_PBTL_LN1.SelectedIndex;
        }

        private void cmb_PBTL_LP1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            //tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_PBTL_LP0.SelectedIndex;
            tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_PBTL_LP1.SelectedIndex;
            //tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_PBTL_LN0.SelectedIndex;
            //tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_PBTL_LN1.SelectedIndex;
        }

        private void cmb_PBTL_LN0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            //tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_PBTL_LP0.SelectedIndex;
            //tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_PBTL_LP1.SelectedIndex;
            tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_PBTL_LN0.SelectedIndex;
            //tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_PBTL_LN1.SelectedIndex;
        }

        private void cmb_PBTL_LN1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            Register tempReg = regMap[0x25];
            //tempReg["MUX_TO_OUT_A"].BFValue = (uint)this.cmb_PBTL_LP0.SelectedIndex;
            //tempReg["MUX_TO_OUT_B"].BFValue = (uint)this.cmb_PBTL_LP1.SelectedIndex;
            //tempReg["MUX_TO_OUT_C"].BFValue = (uint)this.cmb_PBTL_LN0.SelectedIndex;
            tempReg["MUX_TO_OUT_D"].BFValue = (uint)this.cmb_PBTL_LN1.SelectedIndex;
        }

    }
}
