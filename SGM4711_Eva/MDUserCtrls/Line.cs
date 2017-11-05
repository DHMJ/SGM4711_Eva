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
    public partial class Line : UserControl
    {
        public Line()
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
        private bool leftOrUpArrow = false;
        [CategoryAttribute("Style Settings"), DescriptionAttribute("If this line has left arrow")]
        public bool LeftOrUpArrow
        {
            get { return this.leftOrUpArrow; }
            set { this.leftOrUpArrow = value; this.Refresh(); }
        }

        private bool rightOrBelowArrow = false;
        [CategoryAttribute("Style Settings"), DescriptionAttribute("If this line has right arrow")]
        public bool RightOrBelowArrow
        {
            get { return this.rightOrBelowArrow; }
            set { this.rightOrBelowArrow = value; this.Refresh(); }
        }

        private int lineWidth = 2;
        [CategoryAttribute("Style Settings"), DescriptionAttribute("How width of this line")]
        public int LineWidth
        {
            get { return this.lineWidth; }
            set 
            {
                this.lineWidth = (value > this.Width * 0.2) ? (int)(this.Width * 0.2) : 
                    ((value < 1) ? 1 : value);
                this.Refresh();
            }
        }

        private Color lineColor = Color.Black;
        [CategoryAttribute("Style Settings"), DescriptionAttribute("What color os this line")]
        public Color LineColor
        {
            get { return this.lineColor; }
            set { this.lineColor = value; this.Refresh(); }
        }

        private bool horizontal = true;
        [CategoryAttribute("Style Settings"), DescriptionAttribute("Is this line vertical or horizontal")]
        public bool Horizontal
        {
            get { return this.horizontal; }
            set 
            {
                this.horizontal = value;
                int tempLength = this.Width;
                this.Width = this.Height;
                this.Height = tempLength;
                this.Refresh(); 
            }
        }

        private EnumArrowSize arrowSize = EnumArrowSize.medium;
        [CategoryAttribute("Style Settings"), DescriptionAttribute("Set arrow size")]
        public EnumArrowSize ArrowSize
        {
            get { return this.arrowSize; }
            set
            {
                this.arrowSize = value;
                this.Refresh();
            }
        }

        private int arrowSizeUnit = 5;
        public enum EnumArrowSize
        {
            small = 1,
            medium = 2,
            big = 3
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
            Pen myPen = new Pen(lineColor, lineWidth);
            Brush myBrush = new SolidBrush(lineColor);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if(horizontal)
                e.Graphics.DrawLine(myPen, new Point(0, this.Height / 2), new Point(this.Width, this.Height / 2));
            else
                e.Graphics.DrawLine(myPen, new Point(this.Width / 2, 0), new Point(this.Width / 2, this.Height));

            int currentArrowSize = arrowSizeUnit * (int)arrowSize;
            // Draw arrows
            if (this.leftOrUpArrow)
            {
                if(horizontal) // left
                    e.Graphics.FillPolygon(myBrush, new Point[] { new Point(0, this.Height / 2), 
                        new Point(currentArrowSize, 0), new Point(currentArrowSize, this.Height) });
                else           // up 
                    e.Graphics.FillPolygon(myBrush, new Point[] { new Point(this.Width / 2, 0), 
                        new Point(0, currentArrowSize), new Point(this.Width, currentArrowSize) });
            }

            if (this.rightOrBelowArrow)
            {
                if(horizontal) // right
                    e.Graphics.FillPolygon(myBrush, new Point[] { new Point(this.Width, this.Height / 2), 
                        new Point(this.Width - currentArrowSize, 0), new Point(this.Width - currentArrowSize, this.Height) });
                else           // below
                    e.Graphics.FillPolygon(myBrush, new Point[] { new Point(this.Width / 2, this.Height), 
                        new Point(0, this.Height - currentArrowSize), new Point(this.Width, this.Height - currentArrowSize) });
            }
        }

        private void Indicator_SizeChanged(object sender, EventArgs e)
        {
            //this.Height = this.Width;
        }
    }
}
