using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM4711_Eva.MDUserCtrls
{
    public partial class Dot : UserControl
    {
        public Dot()
        {
            InitializeComponent();
        }

        Brush myBrush = Brushes.Black;
        private void myPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(myBrush, new Rectangle(0,0,this.Width, this.Height));
            //e.Graphics.DrawEllipse(myPen, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
        }

        private void Dot_SizeChanged(object sender, EventArgs e)
        {
            this.Width = this.Height;
        }


    }
}
