using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMCommunication;
using GeneralRegConfigPlatform.MDGUI;
using MD.MDCommon;

namespace SGM4711_Eva.GUI
{
    public partial class FormScriptCtrl : Form
    {
        DMDongle myDongle;
        IRegOperation myRegOp;

        public FormScriptCtrl(DMDongle _myDongle, IRegOperation _myRegOp)
        {
            InitializeComponent();

            myDongle = _myDongle;
            myRegOp = _myRegOp;
            FormScript myScript = new FormScript(myDongle, myRegOp);
            this.Controls.Add(myScript);
            myScript.Dock = DockStyle.Fill;
        }
    }
}
