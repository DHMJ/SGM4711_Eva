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
    public partial class InputMux : Form
    {
        RegisterMap regMap;
        IRegOperation myRegOp;
        public InputMux()
        {
            InitializeComponent();
        }

        public InputMux(RegisterMap _regMap, IRegOperation _myRegOp)
        {
            this.myRegOp = _myRegOp;
            this.regMap = _regMap;
            InitializeComponent();
            InitGUI();
        }

        private void InitGUI()
        {
            if (regMap == null)
                return;

            // Left Channel
            switch (regMap[0x20]["SDIN_TO_CH1"].BFValue)
            {
                case 0:
                    rdbtn_CHL_SourceL.Checked = true;
                    break;

                case 1:
                    rdbtn_CHL_SourceR.Checked = true;
                    break;

                case 2:
                    rdbtn_CHL_Zero.Checked = true;
                    break;

                default:
                    break;
            }

            // Right Channel
            switch (regMap[0x20]["SDIN_TO_CH2"].BFValue)
            {
                case 0:
                    rdbtn_CHR_SourceL.Checked = true;
                    break;

                case 1:
                    rdbtn_CHR_SourceR.Checked = true;
                    break;

                case 2:
                    rdbtn_CHR_Zero.Checked = true;
                    break;

                default:
                    break;
            }

            // Sub Channel
            switch (regMap[0x21]["CH4_SOURCE_SEL"].BFValue)
            {
                case 0:
                    rdbtn_SubCH_SourceL.Checked = true;
                    break;

                case 1:
                    rdbtn_SubCH_SourceR.Checked = true;
                    break;

                //case 2:
                //    rdbtn_SubCH_Zero.Checked = true;
                //    break;

                default:
                    break;
            }

            // Sub channel gain
            this.numUP_CH4_Input_Mxier_1.Value = (decimal)((int)regMap[0x61]["CH4_INPUT_MIXER_1[25:0]"].BFValue / Math.Pow(2, 23));
            this.numUP_CH4_Input_Mxier_0.Value = (decimal)((int)regMap[0x61]["CH4_INPUT_MIXER_0[25:0]"].BFValue / Math.Pow(2, 23));
        }

        private void rdbtn_CHL_Source_CheckedChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            uint bfValue = 0;
            bfValue = rdbtn_CHL_SourceL.Checked ? 0u : (rdbtn_CHL_SourceR.Checked ? 1u : 2u);

            regMap[0x20]["SDIN_TO_CH1"].BFValue = bfValue;

            myRegOp.RegWrite(regMap[0x20]);
            myRegOp.UpdateRegSettingSource();
        }

        private void rdbtn_CHR_Source_CheckedChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            uint bfValue = 0;
            bfValue = rdbtn_CHR_SourceL.Checked ? 0u : (rdbtn_CHR_SourceR.Checked ? 1u : 2u);

            regMap[0x20]["SDIN_TO_CH2"].BFValue = bfValue;

            myRegOp.RegWrite(regMap[0x20]);
            myRegOp.UpdateRegSettingSource();
        }

        private void rdbtn_SubCH_Source_CheckedChanged(object sender, EventArgs e)
        {
            if (regMap == null)
                return;

            uint bfValue = 0;
            bfValue = rdbtn_SubCH_SourceL.Checked ? 0u : (rdbtn_SubCH_SourceR.Checked ? 1u : 2u);

            regMap[0x21]["CH4_SOURCE_SEL"].BFValue = bfValue;

            myRegOp.RegWrite(regMap[0x21]);
            myRegOp.UpdateRegSettingSource();
        }


        private void pl_LRMixGain_Sub_Click(object sender, EventArgs e)
        {
            // will set in input mux control

            /* 1. 0x61 BF[31: 16] */
            /* 2. 0x61 BF[15: 0] */
            //UpdateRegSettingSource(0x61, new string[] { "CH4_INPUT_MIXER_1[25:0]", "CH4_INPUT_MIXER_0[25:0]" });
        }

        private void numUP_CH4_Input_Mxier_1_ValueChanged(object sender, EventArgs e)
        {
            // Reg 0x61 CH4_INPUT_MIXER_1[25:0]
            if (regMap == null)
                return;

            regMap[0x61]["CH4_INPUT_MIXER_1[25:0]"].BFValue = 
                (uint)Math.Round((double)this.numUP_CH4_Input_Mxier_1.Value * Math.Pow(2, 23));

            myRegOp.RegWrite(regMap[0x61]);
            myRegOp.UpdateRegSettingSource();
        }

        private void numUP_CH4_Input_Mxier_0_ValueChanged(object sender, EventArgs e)
        {
            // Reg 0x61 CH4_INPUT_MIXER_0[25:0]
            if (regMap == null)
                return;

            regMap[0x61]["CH4_INPUT_MIXER_0[25:0]"].BFValue =
                (uint)Math.Round((double)this.numUP_CH4_Input_Mxier_0.Value * Math.Pow(2, 23));

            myRegOp.RegWrite(regMap[0x61]);
            myRegOp.UpdateRegSettingSource();
        }

    }
}
