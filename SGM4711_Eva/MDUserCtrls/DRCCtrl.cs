using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MD.MDCommon;

namespace SGM4711_Eva.MDUserCtrls
{
    public partial class DRCCtrl : UserControl
    {
        #region Params
        List<Register> regList;
        BitField DRC_EN;

        uint mask_3p23 = 0x3FFFFFF;
        uint mask_2p23 = (uint)Math.Pow(2, 23);

        int fs = 48000;
        // 3.23 formate
        uint ae;
        uint we;
        uint aa;
        uint wa;
        uint ad;
        uint wd;

        uint TdB;   // 9.23 formate
        double slope = 0.5;
        uint K;     // 3.23 formate, slope
        uint O;     // 3.23 formate, offset

        double linearLenRatio = 0.6;
        double maxLenRatio = 0.9;
        int xAxis_Shift = 30;
        int yAxis_Shift = 30;
        int arrowSize = 20;
        static int frameWidth = 2;
        Pen myPen = new Pen(Color.Gray, frameWidth);
        Brush myBrush = new SolidBrush(Color.Gray);

        #endregion

        public DRCCtrl()
        {
            InitializeComponent();
        }

        public DRCCtrl(List<Register> _regList, BitField _DRCEN)
        {
            InitializeComponent();
            this.regList = _regList;
            this.DRC_EN = _DRCEN;

            // Update GUI setting from register value
            UpdateGUISetting();
        }

        private void UpdateGUISetting()
        { }

        private uint CalcTimeConstant(double timeVaule)
        {
            double ta =  -1 / (fs * Math.Log10(timeVaule));
            double ax_d = 1 - Math.Exp((-1 * ta )/ fs);
            return ((uint)ax_d * 2 ^ 23 & mask_3p23);
        }

        private void myPanel_Paint(object sender, PaintEventArgs e)
        {
            Point xy0 = new Point(xAxis_Shift, this.myPanel.Height - yAxis_Shift);
            Point xAxisEnd = new Point(this.myPanel.Width - xAxis_Shift ,this.myPanel.Height - yAxis_Shift);
            Point yAxisEnd = new Point(xAxis_Shift, yAxis_Shift);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw X, Y Axis
            e.Graphics.DrawLine(myPen, xy0, xAxisEnd);
            e.Graphics.DrawLine(myPen, xy0, yAxisEnd);
            
            // Draw Arrow
            e.Graphics.FillPolygon(myBrush, new Point[] { xAxisEnd, 
                new Point(this.myPanel.Width - xAxis_Shift - arrowSize, this.myPanel.Height - yAxis_Shift - arrowSize / 2),
                new Point(this.myPanel.Width - xAxis_Shift - arrowSize, this.myPanel.Height - yAxis_Shift + arrowSize / 2)});

            e.Graphics.FillPolygon(myBrush, new Point[] { yAxisEnd, 
                new Point(xAxis_Shift - arrowSize / 2, yAxis_Shift + arrowSize),
                new Point(xAxis_Shift + arrowSize / 2, yAxis_Shift + arrowSize)});
            
            // Draw label
            e.Graphics.DrawString("Output", this.Font, myBrush, new Point(xAxis_Shift + arrowSize, yAxis_Shift + arrowSize));
            e.Graphics.DrawString("Input", this.Font, myBrush,
                new Point(this.myPanel.Width - 2 * xAxis_Shift - 2 * arrowSize, this.myPanel.Height - yAxis_Shift - arrowSize));

            e.Graphics.TranslateTransform(xAxis_Shift, this.myPanel.Height - yAxis_Shift);
            // Draw Linear line
            int linearLen = (int)((this.Width - 2 * xAxis_Shift) * linearLenRatio);
            e.Graphics.DrawLine(myPen, new Point(0, 0), new Point(linearLen, -linearLen));

            // Draw compression line
            int compressionLen = (int)((this.Width - 2 * xAxis_Shift) * (maxLenRatio - linearLenRatio));
            
            // Draw dash line before compression line because once they are same, dash line will cover real line
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            myPen.Color = Color.LightGray;
            e.Graphics.DrawLine(myPen, new Point(linearLen, -linearLen), 
                new Point(linearLen + (int)(1.5 * compressionLen), -linearLen - (int)(1.5 * compressionLen)));
            e.Graphics.DrawLine(myPen, new Point(linearLen - xAxis_Shift / 2, -linearLen),
                new Point(linearLen + (int)(1.5 * compressionLen), -linearLen));

            if (slope <= 1)
                e.Graphics.DrawLine(myPen, new Point(linearLen + compressionLen, -linearLen -(int)(1.5 * compressionLen)),
                    new Point(linearLen + compressionLen, -linearLen + xAxis_Shift / 2));
            else
                e.Graphics.DrawLine(myPen, new Point(linearLen + (int)(compressionLen / slope), -linearLen - (int)(1.5 * compressionLen)),
                    new Point(linearLen + (int)(compressionLen / slope), -linearLen + xAxis_Shift / 2));
           
            // Draw compression Line
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            myPen.Color = Color.Gray;

            if (slope <= 1)
                e.Graphics.DrawLine(myPen, new Point(linearLen, -linearLen),
                    new Point(linearLen + compressionLen, -linearLen - 1 * (int)(compressionLen * slope)));
            else
                e.Graphics.DrawLine(myPen, new Point(linearLen, -linearLen),
                    new Point(linearLen + (int)(compressionLen / slope), -linearLen - compressionLen));

        }

        private void numUP_EnergyTime_ValueChanged(object sender, EventArgs e)
        {
            ae = CalcTimeConstant((double)this.numUP_EnergyTime.Value);
            we = mask_3p23 + 1 - ae;
        }

        private void numUP_AttackTime_ValueChanged(object sender, EventArgs e)
        {
            aa = CalcTimeConstant((double)this.numUP_AttackTime.Value);
            wa = mask_3p23 + 1 - aa;
        }

        private void numUP_DelayTIme_ValueChanged(object sender, EventArgs e)
        {
            ad = CalcTimeConstant((double)this.numUP_DelayTime.Value);
            wd = mask_3p23 + 1 - ad;
        }

        private void numUP_Threshold_ValueChanged(object sender, EventArgs e)
        {
            double threshold = (double)this.numUP_Threshold.Value;
            double T = (threshold - 24) / -6.0206;
            TdB = (uint)T * mask_2p23;
        }

        private void numUP_Slope_ValueChanged(object sender, EventArgs e)
        {
            slope = (double)this.numUP_Slope.Value;
            K = ((uint)(slope - 1) * mask_2p23) & mask_3p23;

            this.myPanel.Refresh();
        }

        private void numUP_Offset_ValueChanged(object sender, EventArgs e)
        {
            double offset = (double)this.numUP_Offset.Value;
            double Goffset = (Math.Exp(offset / 20)) / 15.5;
            O = (uint)(Goffset * mask_2p23) & mask_3p23;
        }

        private void DRCCtrl_SizeChanged(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                regList[0]["ae[25:0]"].BFValue = ae;
                regList[0]["(1-ae)[25:0]"].BFValue = we;

                regList[1]["aa[25:0]"].BFValue = aa;
                regList[1]["(1-aa)[25:0]"].BFValue = wa;

                regList[2]["ad[25:0]"].BFValue = ad;
                regList[2]["(1-ad)[25:0]"].BFValue = wd;

                regList[3].RegValue = TdB;
                regList[4].RegValue = K;
                regList[5].RegValue = O;
            }
            catch 
            {
                MessageBox.Show("Update failed!!!");
            }
        }

    }
}
