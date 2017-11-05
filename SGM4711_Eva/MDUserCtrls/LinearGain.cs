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
    public partial class LinearGain : UserControl
    {
        public LinearGain()
        {
            InitializeComponent();
        }

        /***************************************************************************************
         *  属性值	                含义
         *  CategoryAttribute	    该属性对在Property控件中的属性按字母顺序进行归类
         *  DescriptionAttribute	其值为对每个属性的具体文字描述，将会显示在property控件的底部
         *  BrowsableAttribute	    该值为是否在property控件中显示或者隐藏某个属性
         *  ReadOnlyAttribute	    该值为某个属性值是否在property控件中只读
         *  DefaultValueAttribute	每个属性的默认值
         ***************************************************************************************/
        private EnumArrowDirection arrowDirection = EnumArrowDirection.Left;
        [CategoryAttribute("Style Settings"), DescriptionAttribute("Choose which direction of the triangle point to")]
        public EnumArrowDirection ArrowDirection
        {
            get { return this.arrowDirection; }
            set { this.arrowDirection = value; this.Refresh(); }
        }

        private Color frameColor = Color.Black;
        [CategoryAttribute("Style Settings"), DescriptionAttribute("What color of this frame")]
        public Color FrameColor
        {
            get { return this.frameColor; }
            set { this.frameColor = value; this.Refresh(); }
        }

        private int gain = -1;
        private int maxGain = 9;
        private int minGain = -9;
        [CategoryAttribute("Style Settings"), DescriptionAttribute("What's the gain will be displayed")]
        public int Gain
        {
            get { return this.gain; }
            set
            {
                this.gain = value > maxGain ? maxGain : (value < minGain ? minGain : value);                    

                this.Refresh();
            }
        }

        public enum EnumArrowDirection
        {
            Left = 0,
            Right = 1,
            Up = 2,
            Below = 3
        }

        private void myPanel_Paint(object sender, PaintEventArgs e)
        {
            /*
            Graphics gra = this.pictureBox1.CreateGraphics();
            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush bush = new SolidBrush(Color.Green);//填充的颜色
            gra.FillEllipse(bush, 10, 10, 100, 100);//画填充椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50

            画圆圈：
            Graphics gra = this.pictureBox1.CreateGraphics();
            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Pink);//画笔颜色
            gra.DrawEllipse(pen, 250, 10, 100, 100);//画椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50
            */

            Pen myPen = new Pen(frameColor);
            Brush brush_string = Brushes.Black;

            SizeF tempSize = e.Graphics.MeasureString(gain.ToString(), this.Font);
            PointF stringPoint = new PointF(0, 0);
            int offset = 0;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            switch (arrowDirection)
            {
                case EnumArrowDirection.Left:
                    stringPoint = new PointF(this.Width - tempSize.Width + 2 - offset,
                this.Height / 2f - tempSize.Height / 2f + 2);

                    e.Graphics.DrawPolygon(myPen, new Point[]{new Point(1, this.Height / 2), 
                        new Point(this.Width - 1, 1), new Point(this.Width - 1, this.Height - 1)});
                    break;
                case EnumArrowDirection.Right:
                    stringPoint = new PointF(offset, this.Height / 2f - tempSize.Height / 2f);

                    e.Graphics.DrawPolygon(myPen, new Point[]{new Point(1, 1), 
                        new Point(1, this.Height - 1), new Point(this.Width - 1, this.Height / 2)});
                    break;
                case EnumArrowDirection.Up:
                    stringPoint = new PointF(this.Width / 2f - tempSize.Width / 2f,
this.Height - tempSize.Height - offset);

                    e.Graphics.DrawPolygon(myPen, new Point[]{new Point(this.Width / 2, 1), 
                        new Point(1, this.Height - 1), new Point(this.Width - 1, this.Height - 1)});
                    break;
                case EnumArrowDirection.Below:
                    stringPoint = new PointF(this.Width / 2f - tempSize.Width / 2f, offset);

                    e.Graphics.DrawPolygon(myPen, new Point[]{new Point(1, 1), 
                        new Point(this.Width - 1, 1), new Point(this.Width / 2, this.Height - 1)});
                    break;
            }

            // Paint gain
            e.Graphics.DrawString(gain.ToString(), this.Font, brush_string, stringPoint);
        }

        private void myPanel_SizeChanged(object sender, EventArgs e)
        {
            this.Height = this.Width;
        }
    }
}
