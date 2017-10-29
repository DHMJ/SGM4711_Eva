using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGM4711_Eva.MDUserCtrls;
using MD.MDCommon;

namespace SGM4711_Eva.GUI
{
    public partial class DRCForm : Form
    {
        DRCCtrl myDRC;
        public DRCForm(List<Register> _regList, BitField _DRCEN)
        {
            InitializeComponent();

            myDRC = new DRCCtrl(_regList, _DRCEN);
            this.Controls.Add(myDRC);
            myDRC.Location = new Point(0, 0);
        }

    }
}
