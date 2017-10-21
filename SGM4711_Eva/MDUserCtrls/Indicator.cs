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
    public partial class Indicator : UserControl
    {
        public Indicator()
        {
            InitializeComponent();
        }

        Color indicatorColorFalse = Color.GreenYellow;
        Color indicatorColorTrue = Color.IndianRed;
        /***************************************************************************************
         *  属性值	                含义
         *  CategoryAttribute	    该属性对在Property控件中的属性按字母顺序进行归类
         *  DescriptionAttribute	其值为对每个属性的具体文字描述，将会显示在property控件的底部
         *  BrowsableAttribute	    该值为是否在property控件中显示或者隐藏某个属性
         *  ReadOnlyAttribute	    该值为某个属性值是否在property控件中只读
         *  DefaultValueAttribute	每个属性的默认值
         ***************************************************************************************/
        private bool indicatorColorReverse = false;
        [CategoryAttribute("Indicator Color Settings"),
        DescriptionAttribute("Decide if indicator color showing reverse with the value")]
        public bool IndicatorColorReverse
        {
            get { return this.indicatorColorReverse; }
            set { this.indicatorColorReverse = value; }
        }

        private bool indicatorValue = false;
        [CategoryAttribute("Indicator Color Settings"),
        ReadOnlyAttribute(true),
        DescriptionAttribute("Decide if indicator color showing reverse with the value")]
        public bool IndicatorValue
        {
            get { return this.indicatorValue; }
            set { this.indicatorValue = value; }
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
            Pen myPen = new Pen(Color.LightBlue);
            
            Brush myBrush;
            if(indicatorColorReverse ^ indicatorValue)
                myBrush = new SolidBrush(indicatorColorFalse);
            else
                myBrush = new SolidBrush(indicatorColorTrue);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawEllipse(myPen, new Rectangle(0, 0, this.Width - 2, this.Height - 2));
            //e.Graphics.DrawEllipse(myPen, this.ClientRectangle);

            e.Graphics.FillEllipse(myBrush, new Rectangle(0, 0, this.Width - 2, this.Height - 2));
        }

        private void Indicator_SizeChanged(object sender, EventArgs e)
        {
            this.Height = this.Width;
        }
    }
}
