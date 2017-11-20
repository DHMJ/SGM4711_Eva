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
    public partial class Mixer_1In : Form
    {
        IRegOperation myRegOp;
        string inputBF;
        Register reg;
        int format_FractionalCount = 23;
        public Mixer_1In(Register _reg, string _inputBF, IRegOperation _myRegOp)
        {
            InitializeComponent();

            reg = _reg;
            this.inputBF = _inputBF;
            this.myRegOp = _myRegOp;

            InitGUI();
        }


        public Mixer_1In(Register _reg, string _inputBF, IRegOperation _myRegOp, int _fractional)
        {
            InitializeComponent();

            reg = _reg;
            this.inputBF = _inputBF;
            this.myRegOp = _myRegOp;
            format_FractionalCount = _fractional;

            InitGUI();
        }

        private void InitGUI()
        {
            this.numUP_Input.ValueChanged -= numUP_Input_ValueChanged;

            if (reg.Contain(inputBF))
                this.numUP_Input.Value = (decimal)((double)reg[inputBF].BFValue / Math.Pow(2, format_FractionalCount));

            this.numUP_Input.ValueChanged += numUP_Input_ValueChanged;
        }

        private void numUP_Input_ValueChanged(object sender, EventArgs e)
        {
            reg[inputBF].BFValue = (uint)Math.Round((double)this.numUP_Input.Value * Math.Pow(2, format_FractionalCount));

            myRegOp.RegWrite(reg);
            myRegOp.UpdateRegSettingSource();
        }


    }
}
