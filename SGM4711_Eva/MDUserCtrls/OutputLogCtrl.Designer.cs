namespace SGM4711_Eva.MDUserCtrls
{
    partial class OutputLogCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtxt_OutputLog = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip_SelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxt_OutputLog
            // 
            this.rtxt_OutputLog.BackColor = System.Drawing.Color.White;
            this.rtxt_OutputLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_OutputLog.Font = new System.Drawing.Font("Arial", 9F);
            this.rtxt_OutputLog.Location = new System.Drawing.Point(0, 0);
            this.rtxt_OutputLog.Name = "rtxt_OutputLog";
            this.rtxt_OutputLog.ReadOnly = true;
            this.rtxt_OutputLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxt_OutputLog.Size = new System.Drawing.Size(336, 157);
            this.rtxt_OutputLog.TabIndex = 1;
            this.rtxt_OutputLog.Text = "";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuStrip_SelAll,
            this.contextMenuStrip_Copy,
            this.contextMenuStrip_Paste,
            this.toolStripSeparator1,
            this.contextMenuStrip_Clear});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(164, 98);
            // 
            // contextMenuStrip_SelAll
            // 
            this.contextMenuStrip_SelAll.Name = "contextMenuStrip_SelAll";
            this.contextMenuStrip_SelAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.contextMenuStrip_SelAll.Size = new System.Drawing.Size(163, 22);
            this.contextMenuStrip_SelAll.Text = "Select &All";
            this.contextMenuStrip_SelAll.Click += new System.EventHandler(this.contextMenuStrip_SelAll_Click);
            // 
            // contextMenuStrip_Copy
            // 
            this.contextMenuStrip_Copy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_Copy.Name = "contextMenuStrip_Copy";
            this.contextMenuStrip_Copy.Size = new System.Drawing.Size(163, 22);
            this.contextMenuStrip_Copy.Text = "&Copy";
            this.contextMenuStrip_Copy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip_Copy_MouseUp);
            // 
            // contextMenuStrip_Paste
            // 
            this.contextMenuStrip_Paste.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_Paste.Name = "contextMenuStrip_Paste";
            this.contextMenuStrip_Paste.Size = new System.Drawing.Size(163, 22);
            this.contextMenuStrip_Paste.Text = "&Paste";
            this.contextMenuStrip_Paste.Visible = false;
            this.contextMenuStrip_Paste.Click += new System.EventHandler(this.contextMenuStrip_Paste_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // contextMenuStrip_Clear
            // 
            this.contextMenuStrip_Clear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_Clear.Name = "contextMenuStrip_Clear";
            this.contextMenuStrip_Clear.Size = new System.Drawing.Size(163, 22);
            this.contextMenuStrip_Clear.Text = "C&lear";
            this.contextMenuStrip_Clear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip_Clear_MouseUp);
            // 
            // OutputLogCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtxt_OutputLog);
            this.Name = "OutputLogCtrl";
            this.Size = new System.Drawing.Size(336, 157);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_OutputLog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_SelAll;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_Copy;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_Clear;
    }
}
