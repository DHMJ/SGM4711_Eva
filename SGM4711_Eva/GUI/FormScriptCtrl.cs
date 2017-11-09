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

namespace SGM4711_Eva.GUI
{
    public partial class FormScriptCtrl : Form
    {
        DMDongle myDongle;
        public FormScriptCtrl(DMDongle _myDongle)
        {
            InitializeComponent();

            myDongle = _myDongle;
            FormScript myScript = new FormScript(myDongle);
            this.Controls.Add(myScript);
            myScript.Dock = DockStyle.Fill;
        }
    }
}
