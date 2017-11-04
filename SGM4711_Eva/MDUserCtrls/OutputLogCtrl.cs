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
    public partial class OutputLogCtrl : UserControl
    {
        public OutputLogCtrl()
        {
            InitializeComponent();
        }

        public void AppendLog(string strLog)
        {
            int length = strLog.Length;
            int beginIndex = rtxt_OutputLog.Text.Length;
            rtxt_OutputLog.AppendText(strLog + "\r\n");
            //rtxt_OutputLog.ForeColor = Color.Chartreuse;
            //rtxt_OutputLog.Select(beginIndex, length);
            //rtxt_OutputLog.SelectionColor = fontColor;
            rtxt_OutputLog.Select(rtxt_OutputLog.Text.Length, 0);//.SelectedText = "";
            rtxt_OutputLog.ScrollToCaret();
            rtxt_OutputLog.Refresh();
        }

        public void AppendLog(string strLog, Color fontColor)
        {
            int length = strLog.Length;
            int beginIndex = rtxt_OutputLog.Text.Length;
            rtxt_OutputLog.AppendText(strLog + "\r\n");
            //rtxt_OutputLog.ForeColor = Color.Chartreuse;
            rtxt_OutputLog.Select(beginIndex, length);
            rtxt_OutputLog.SelectionColor = fontColor;
            rtxt_OutputLog.Select(rtxt_OutputLog.Text.Length, 0);//.SelectedText = "";
            rtxt_OutputLog.ScrollToCaret();
            rtxt_OutputLog.Refresh();
        }

        public void AppendLog(string strError, Color fontColor, bool blankLineBefore)
        {
            int length = strError.Length;
            int beginIndex = rtxt_OutputLog.Text.Length;
            
            if (blankLineBefore)
                rtxt_OutputLog.AppendText("\r\n");

            rtxt_OutputLog.AppendText(strError + "\r\n");
            //rtxt_OutputLog.ForeColor = Color.Chartreuse;
            rtxt_OutputLog.Select(beginIndex, length);
            rtxt_OutputLog.SelectionColor = fontColor;
            rtxt_OutputLog.Select(rtxt_OutputLog.Text.Length, 0);//.SelectedText = "";
            rtxt_OutputLog.ScrollToCaret();
            rtxt_OutputLog.Refresh();
        }


        private void contextMenuStrip_Copy_MouseUp(object sender, MouseEventArgs e)
        {
            this.rtxt_OutputLog.Copy();
        }

        private void contextMenuStrip_Paste_Click(object sender, EventArgs e)
        {
            this.rtxt_OutputLog.Paste();
        }

        private void contextMenuStrip_Clear_MouseUp(object sender, MouseEventArgs e)
        {
            this.rtxt_OutputLog.Text = null;
            //解决Scroll Bar的刷新问题。
            this.rtxt_OutputLog.ScrollBars = RichTextBoxScrollBars.None;
            this.rtxt_OutputLog.ScrollBars = RichTextBoxScrollBars.Both;
        }

        private void contextMenuStrip_SelAll_Click(object sender, EventArgs e)
        {
            this.rtxt_OutputLog.SelectAll();
        }

        private void rtxt_OutputLog_TextChanged(object sender, EventArgs e)
        {
            //if (rtxt_OutputLog.TextLength > (int)(rtxt_OutputLog.MaxLength * 0.5))
            ////if (rtxt_OutputLog.TextLength > 100)
            //{
            //    rtxt_OutputLog.Text = rtxt_OutputLog.Text.Substring(rtxt_OutputLog.Text.Length - (int)(rtxt_OutputLog.MaxLength * 0.5), (int)(rtxt_OutputLog.MaxLength * 0.5));
            //    rtxt_OutputLog.ForeColor = Color.Black;
            //    //rtxt_OutputLog.Text = rtxt_OutputLog.Text.Substring(rtxt_OutputLog.Text.Length - 100, 100);
            //    rtxt_OutputLog.SelectionStart = rtxt_OutputLog.Text.Length;
            //    rtxt_OutputLog.ScrollToCaret();                    
            //    rtxt_OutputLog.Refresh();

            //}
        }

    }
}
