namespace SGM4711_Eva.MDUserCtrls
{
    partial class I2CMemTool
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
            this.lbl_RowCount = new System.Windows.Forms.Label();
            this.numUP_RWCount = new System.Windows.Forms.NumericUpDown();
            this.btn_Write = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUP_I2CAddr = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Display = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_RWCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_I2CAddr)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_RowCount
            // 
            this.lbl_RowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RowCount.AutoSize = true;
            this.lbl_RowCount.Location = new System.Drawing.Point(124, 8);
            this.lbl_RowCount.Name = "lbl_RowCount";
            this.lbl_RowCount.Size = new System.Drawing.Size(35, 12);
            this.lbl_RowCount.TabIndex = 7;
            this.lbl_RowCount.Text = "Count";
            // 
            // numUP_RWCount
            // 
            this.numUP_RWCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUP_RWCount.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numUP_RWCount.Location = new System.Drawing.Point(124, 25);
            this.numUP_RWCount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUP_RWCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUP_RWCount.Name = "numUP_RWCount";
            this.numUP_RWCount.Size = new System.Drawing.Size(71, 21);
            this.numUP_RWCount.TabIndex = 6;
            this.numUP_RWCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_RWCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUP_RWCount.ValueChanged += new System.EventHandler(this.numUP_RWCount_ValueChanged);
            // 
            // btn_Write
            // 
            this.btn_Write.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Write.AutoSize = true;
            this.btn_Write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Write.Location = new System.Drawing.Point(330, 23);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(71, 24);
            this.btn_Write.TabIndex = 5;
            this.btn_Write.Text = "Write";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Read.AutoSize = true;
            this.btn_Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Read.Location = new System.Drawing.Point(227, 23);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(71, 24);
            this.btn_Read.TabIndex = 4;
            this.btn_Read.Text = "Read";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start Address";
            // 
            // numUP_I2CAddr
            // 
            this.numUP_I2CAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUP_I2CAddr.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numUP_I2CAddr.Hexadecimal = true;
            this.numUP_I2CAddr.Location = new System.Drawing.Point(21, 25);
            this.numUP_I2CAddr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUP_I2CAddr.Name = "numUP_I2CAddr";
            this.numUP_I2CAddr.Size = new System.Drawing.Size(71, 21);
            this.numUP_I2CAddr.TabIndex = 8;
            this.numUP_I2CAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_I2CAddr.ValueChanged += new System.EventHandler(this.numUP_I2CAddr_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numUP_I2CAddr);
            this.panel1.Controls.Add(this.btn_Read);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Write);
            this.panel1.Controls.Add(this.numUP_RWCount);
            this.panel1.Controls.Add(this.lbl_RowCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 64);
            this.panel1.TabIndex = 11;
            // 
            // txt_Display
            // 
            this.txt_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Display.Location = new System.Drawing.Point(0, 64);
            this.txt_Display.Multiline = true;
            this.txt_Display.Name = "txt_Display";
            this.txt_Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Display.Size = new System.Drawing.Size(427, 197);
            this.txt_Display.TabIndex = 12;
            // 
            // I2CMemTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_Display);
            this.Controls.Add(this.panel1);
            this.Name = "I2CMemTool";
            this.Size = new System.Drawing.Size(427, 261);
            ((System.ComponentModel.ISupportInitialize)(this.numUP_RWCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_I2CAddr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RowCount;
        private System.Windows.Forms.NumericUpDown numUP_RWCount;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUP_I2CAddr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Display;
    }
}
