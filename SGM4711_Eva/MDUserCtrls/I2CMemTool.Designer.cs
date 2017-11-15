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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdb_Bytes = new System.Windows.Forms.RadioButton();
            this.rdb_Regs = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_RWCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_I2CAddr)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_RowCount
            // 
            this.lbl_RowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RowCount.AutoSize = true;
            this.lbl_RowCount.Location = new System.Drawing.Point(105, 8);
            this.lbl_RowCount.Name = "lbl_RowCount";
            this.lbl_RowCount.Size = new System.Drawing.Size(35, 12);
            this.lbl_RowCount.TabIndex = 7;
            this.lbl_RowCount.Text = "Count";
            // 
            // numUP_RWCount
            // 
            this.numUP_RWCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUP_RWCount.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numUP_RWCount.Location = new System.Drawing.Point(105, 25);
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
            this.numUP_RWCount.Size = new System.Drawing.Size(59, 21);
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
            this.btn_Write.Location = new System.Drawing.Point(340, 23);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(61, 24);
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
            this.btn_Read.Location = new System.Drawing.Point(273, 23);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(61, 24);
            this.btn_Read.TabIndex = 4;
            this.btn_Read.Text = "Read";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 8);
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
            this.numUP_I2CAddr.Location = new System.Drawing.Point(18, 25);
            this.numUP_I2CAddr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUP_I2CAddr.Name = "numUP_I2CAddr";
            this.numUP_I2CAddr.Size = new System.Drawing.Size(59, 21);
            this.numUP_I2CAddr.TabIndex = 8;
            this.numUP_I2CAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_I2CAddr.ValueChanged += new System.EventHandler(this.numUP_I2CAddr_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.rdb_Bytes);
            this.panel2.Controls.Add(this.rdb_Regs);
            this.panel2.Location = new System.Drawing.Point(174, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 49);
            this.panel2.TabIndex = 10;
            // 
            // rdb_Bytes
            // 
            this.rdb_Bytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_Bytes.AutoSize = true;
            this.rdb_Bytes.Checked = true;
            this.rdb_Bytes.Location = new System.Drawing.Point(3, 3);
            this.rdb_Bytes.Name = "rdb_Bytes";
            this.rdb_Bytes.Size = new System.Drawing.Size(53, 16);
            this.rdb_Bytes.TabIndex = 0;
            this.rdb_Bytes.TabStop = true;
            this.rdb_Bytes.Text = "Bytes";
            this.rdb_Bytes.UseVisualStyleBackColor = true;
            // 
            // rdb_Regs
            // 
            this.rdb_Regs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_Regs.AutoSize = true;
            this.rdb_Regs.Location = new System.Drawing.Point(3, 25);
            this.rdb_Regs.Name = "rdb_Regs";
            this.rdb_Regs.Size = new System.Drawing.Size(77, 16);
            this.rdb_Regs.TabIndex = 0;
            this.rdb_Regs.Text = "Registers";
            this.rdb_Regs.UseVisualStyleBackColor = true;
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdb_Bytes;
        private System.Windows.Forms.RadioButton rdb_Regs;
    }
}
