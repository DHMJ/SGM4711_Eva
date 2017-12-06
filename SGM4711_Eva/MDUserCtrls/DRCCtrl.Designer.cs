namespace SGM4711_Eva.MDUserCtrls
{
    partial class DRCCtrl
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
            this.numUP_EnergyTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numUP_AttackTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numUP_DecayTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.myPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numUP_Threshold = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numUP_Slope = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numUP_Offset = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.chb_Enable = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ImportDRC = new System.Windows.Forms.Button();
            this.btn_ExportDRC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_EnergyTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_AttackTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_DecayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_Threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_Slope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_Offset)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numUP_EnergyTime
            // 
            this.numUP_EnergyTime.Location = new System.Drawing.Point(25, 27);
            this.numUP_EnergyTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUP_EnergyTime.Name = "numUP_EnergyTime";
            this.numUP_EnergyTime.Size = new System.Drawing.Size(66, 21);
            this.numUP_EnergyTime.TabIndex = 0;
            this.numUP_EnergyTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_EnergyTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUP_EnergyTime.ValueChanged += new System.EventHandler(this.numUP_EnergyTime_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 7.5F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(96, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 7.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(204, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "ms";
            // 
            // numUP_AttackTime
            // 
            this.numUP_AttackTime.Location = new System.Drawing.Point(132, 27);
            this.numUP_AttackTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUP_AttackTime.Name = "numUP_AttackTime";
            this.numUP_AttackTime.Size = new System.Drawing.Size(66, 21);
            this.numUP_AttackTime.TabIndex = 6;
            this.numUP_AttackTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_AttackTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUP_AttackTime.ValueChanged += new System.EventHandler(this.numUP_AttackTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 7.5F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(311, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "ms";
            // 
            // numUP_DecayTime
            // 
            this.numUP_DecayTime.Location = new System.Drawing.Point(239, 27);
            this.numUP_DecayTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUP_DecayTime.Name = "numUP_DecayTime";
            this.numUP_DecayTime.Size = new System.Drawing.Size(66, 21);
            this.numUP_DecayTime.TabIndex = 8;
            this.numUP_DecayTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_DecayTime.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUP_DecayTime.ValueChanged += new System.EventHandler(this.numUP_DecayTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 7.5F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(25, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Energy Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 7.5F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(132, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Attack Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 7.5F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(239, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Decay Time";
            // 
            // myPanel
            // 
            this.myPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.myPanel.Location = new System.Drawing.Point(0, 0);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(537, 537);
            this.myPanel.TabIndex = 11;
            this.myPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.myPanel_Paint);
            this.myPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myPanel_MouseDown);
            this.myPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myPanel_MouseMove);
            this.myPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myPanel_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 7.5F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(25, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Threshold";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 7.5F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(96, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "dB";
            // 
            // numUP_Threshold
            // 
            this.numUP_Threshold.DecimalPlaces = 2;
            this.numUP_Threshold.Location = new System.Drawing.Point(25, 75);
            this.numUP_Threshold.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numUP_Threshold.Minimum = new decimal(new int[] {
            140,
            0,
            0,
            -2147483648});
            this.numUP_Threshold.Name = "numUP_Threshold";
            this.numUP_Threshold.Size = new System.Drawing.Size(66, 21);
            this.numUP_Threshold.TabIndex = 12;
            this.numUP_Threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_Threshold.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.numUP_Threshold.ValueChanged += new System.EventHandler(this.numUP_Threshold_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 7.5F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(132, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "Slope ( Out : Input)";
            // 
            // numUP_Slope
            // 
            this.numUP_Slope.DecimalPlaces = 3;
            this.numUP_Slope.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUP_Slope.Location = new System.Drawing.Point(132, 75);
            this.numUP_Slope.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUP_Slope.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numUP_Slope.Name = "numUP_Slope";
            this.numUP_Slope.Size = new System.Drawing.Size(66, 21);
            this.numUP_Slope.TabIndex = 15;
            this.numUP_Slope.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_Slope.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUP_Slope.ValueChanged += new System.EventHandler(this.numUP_Slope_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 7.5F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(239, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "Offset";
            // 
            // numUP_Offset
            // 
            this.numUP_Offset.DecimalPlaces = 2;
            this.numUP_Offset.Location = new System.Drawing.Point(239, 75);
            this.numUP_Offset.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numUP_Offset.Minimum = new decimal(new int[] {
            140,
            0,
            0,
            -2147483648});
            this.numUP_Offset.Name = "numUP_Offset";
            this.numUP_Offset.Size = new System.Drawing.Size(66, 21);
            this.numUP_Offset.TabIndex = 18;
            this.numUP_Offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_Offset.ValueChanged += new System.EventHandler(this.numUP_Offset_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 7.5F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(311, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "dB";
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Location = new System.Drawing.Point(98, 65);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(66, 22);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // chb_Enable
            // 
            this.chb_Enable.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_Enable.BackColor = System.Drawing.Color.IndianRed;
            this.chb_Enable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chb_Enable.Location = new System.Drawing.Point(17, 65);
            this.chb_Enable.Name = "chb_Enable";
            this.chb_Enable.Size = new System.Drawing.Size(66, 22);
            this.chb_Enable.TabIndex = 42;
            this.chb_Enable.Text = "Disabled";
            this.chb_Enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_Enable.UseVisualStyleBackColor = false;
            this.chb_Enable.CheckedChanged += new System.EventHandler(this.chb_Enable_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.numUP_Offset);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.numUP_Slope);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numUP_Threshold);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numUP_DecayTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numUP_AttackTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numUP_EnergyTime);
            this.panel1.Location = new System.Drawing.Point(3, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 122);
            this.panel1.TabIndex = 43;
            // 
            // btn_ImportDRC
            // 
            this.btn_ImportDRC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ImportDRC.Location = new System.Drawing.Point(17, 17);
            this.btn_ImportDRC.Name = "btn_ImportDRC";
            this.btn_ImportDRC.Size = new System.Drawing.Size(66, 22);
            this.btn_ImportDRC.TabIndex = 43;
            this.btn_ImportDRC.Text = "Import";
            this.btn_ImportDRC.UseVisualStyleBackColor = true;
            this.btn_ImportDRC.Click += new System.EventHandler(this.btn_ImportDRC_Click);
            // 
            // btn_ExportDRC
            // 
            this.btn_ExportDRC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ExportDRC.Location = new System.Drawing.Point(98, 17);
            this.btn_ExportDRC.Name = "btn_ExportDRC";
            this.btn_ExportDRC.Size = new System.Drawing.Size(66, 22);
            this.btn_ExportDRC.TabIndex = 44;
            this.btn_ExportDRC.Text = "Export";
            this.btn_ExportDRC.UseVisualStyleBackColor = true;
            this.btn_ExportDRC.Click += new System.EventHandler(this.btn_ExportDRC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ImportDRC);
            this.groupBox1.Controls.Add(this.btn_ExportDRC);
            this.groupBox1.Controls.Add(this.chb_Enable);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Location = new System.Drawing.Point(338, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 98);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // DRCCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.myPanel);
            this.MaximumSize = new System.Drawing.Size(537, 668);
            this.MinimumSize = new System.Drawing.Size(537, 668);
            this.Name = "DRCCtrl";
            this.Size = new System.Drawing.Size(537, 668);
            this.SizeChanged += new System.EventHandler(this.DRCCtrl_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numUP_EnergyTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_AttackTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_DecayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_Threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_Slope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_Offset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUP_EnergyTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUP_AttackTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUP_DecayTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numUP_Threshold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numUP_Slope;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numUP_Offset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.CheckBox chb_Enable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ImportDRC;
        private System.Windows.Forms.Button btn_ExportDRC;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
