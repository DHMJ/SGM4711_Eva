namespace SGM4711_Eva.MDUserCtrls
{
    partial class LinearGain
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
            this.myPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // myPanel
            // 
            this.myPanel.BackColor = System.Drawing.Color.Transparent;
            this.myPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPanel.Location = new System.Drawing.Point(0, 0);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(20, 20);
            this.myPanel.TabIndex = 1;
            this.myPanel.SizeChanged += new System.EventHandler(this.myPanel_SizeChanged);
            this.myPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.myPanel_Paint);
            // 
            // LinearGain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.myPanel);
            this.Name = "LinearGain";
            this.Size = new System.Drawing.Size(20, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel myPanel;
    }
}
