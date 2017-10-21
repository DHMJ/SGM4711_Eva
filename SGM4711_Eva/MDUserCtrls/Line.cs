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
        private bool leftArrow = false;
        [CategoryAttribute("Style Settings"), DescriptionAttribute("If this line has left arrow")]
        public bool LeftArrow
        {
            get { return this.leftArrow; }
            set { this.leftArrow = value; this.Refresh(); }
        }

        private bool rightArrow = false;
        [CategoryAttribute("Style Settings"), DescriptionAttribute("If this line has right arrow")]
        public bool RightArrow
        {
            get { return this.rightArrow; }
            set { this.rightArrow = value; this.Refresh(); }
        }

        private int lineWidth = 1;
        [CategoryAttribute("Style Settings"), DescriptionAttribute("How width of this line")]
        public int LineWidth
        {
            get { return this.lineWidth; }
            set 
            {
                this.lineWidth = (value > this.Width * 0.2) ? (int)(this.Width * 0.2) : 
                    ((value < 1) ? 2 : value);
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
            e.Graphics.DrawLine(myPen, new Point(0, this.Height / 2), new Point(this.Width, this.Height / 2));

            // Draw arrows
            if (this.leftArrow)
                e.Graphics.FillPolygon(myBrush, new Point[] { new Point(0, this.Height / 2), 
                    new Point(10, 0), new Point(10, this.Height) });
            if (this.rightArrow)
                e.Graphics.FillPolygon(myBrush, new Point[] { new Point(this.Width, this.Height / 2), 
                    new Point(this.Width - 10, 0), new Point(this.Width - 10, this.Height) });
        }

        private void Indicator_SizeChanged(object sender, EventArgs e)
        {
            //this.Height = this.Width;
        }
    }
}
