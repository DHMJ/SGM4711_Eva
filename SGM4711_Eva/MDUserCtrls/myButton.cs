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
    public partial class myButton : Button
    {
        //public myButton()
        //{
        //    InitializeComponent();
        //}

        public new event EventHandler DoubleClick;    
        DateTime clickTime;    
        bool isClicked = false;    
        protected override void OnClick(EventArgs e)    
        {    
            base.OnClick(e);
            //Console.WriteLine(DateTime.Now.ToLongTimeString() + clickTime.ToLongTimeString());
            if (isClicked)    
            {    
                TimeSpan span = DateTime.Now - clickTime;
                //Console.WriteLine(span.TotalMilliseconds);
                if (span.TotalMilliseconds < SystemInformation.DoubleClickTime)    
                {
                    if (DoubleClick != null)
                    {
                        DoubleClick(this, e);
                        isClicked = false;
                    }
                }    
                else  
                {  
                    isClicked = true;    
                    clickTime = DateTime.Now;    
                }  
            }    
            else   
            {    
                isClicked = true;    
                clickTime = DateTime.Now;    
            }    
        }    
    }    
    
}
