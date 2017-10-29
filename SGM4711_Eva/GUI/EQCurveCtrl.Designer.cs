namespace SGM4711_Eva.GUI
{
    partial class EQCurveCtrl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_EQCurveSetting = new System.Windows.Forms.Panel();
            this.btn_Download_EQParam = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numUP_MaxMagn = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numUP_MaxFreq = new System.Windows.Forms.NumericUpDown();
            this.numUP_MinMagn = new System.Windows.Forms.NumericUpDown();
            this.numUP_MinFreq = new System.Windows.Forms.NumericUpDown();
            this.lbl_MinFreq = new System.Windows.Forms.Label();
            this.FilterSettingPanel = new System.Windows.Forms.Panel();
            this.dgv_filterSetting = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SubType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Freq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Bypass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CurveColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EQ_CurvePanel = new System.Windows.Forms.Panel();
            this.pnl_EQCurveSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MaxMagn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MaxFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MinMagn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MinFreq)).BeginInit();
            this.FilterSettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filterSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_EQCurveSetting
            // 
            this.pnl_EQCurveSetting.BackColor = System.Drawing.Color.White;
            this.pnl_EQCurveSetting.Controls.Add(this.btn_Download_EQParam);
            this.pnl_EQCurveSetting.Controls.Add(this.label5);
            this.pnl_EQCurveSetting.Controls.Add(this.label2);
            this.pnl_EQCurveSetting.Controls.Add(this.label4);
            this.pnl_EQCurveSetting.Controls.Add(this.numUP_MaxMagn);
            this.pnl_EQCurveSetting.Controls.Add(this.label1);
            this.pnl_EQCurveSetting.Controls.Add(this.label3);
            this.pnl_EQCurveSetting.Controls.Add(this.numUP_MaxFreq);
            this.pnl_EQCurveSetting.Controls.Add(this.numUP_MinMagn);
            this.pnl_EQCurveSetting.Controls.Add(this.numUP_MinFreq);
            this.pnl_EQCurveSetting.Controls.Add(this.lbl_MinFreq);
            this.pnl_EQCurveSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_EQCurveSetting.Location = new System.Drawing.Point(0, 0);
            this.pnl_EQCurveSetting.Name = "pnl_EQCurveSetting";
            this.pnl_EQCurveSetting.Size = new System.Drawing.Size(775, 46);
            this.pnl_EQCurveSetting.TabIndex = 1;
            this.pnl_EQCurveSetting.SizeChanged += new System.EventHandler(this.pnl_EQCurveSetting_SizeChanged);
            // 
            // btn_Download_EQParam
            // 
            this.btn_Download_EQParam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Download_EQParam.Location = new System.Drawing.Point(669, 12);
            this.btn_Download_EQParam.Name = "btn_Download_EQParam";
            this.btn_Download_EQParam.Size = new System.Drawing.Size(75, 23);
            this.btn_Download_EQParam.TabIndex = 6;
            this.btn_Download_EQParam.Text = "Download";
            this.btn_Download_EQParam.UseVisualStyleBackColor = true;
            this.btn_Download_EQParam.Click += new System.EventHandler(this.btn_Download_EQParam_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Magnitude (dB)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(493, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 10);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Frequency (Hz)";
            // 
            // numUP_MaxMagn
            // 
            this.numUP_MaxMagn.Location = new System.Drawing.Point(522, 15);
            this.numUP_MaxMagn.Maximum = new decimal(new int[] {
            24000,
            0,
            0,
            0});
            this.numUP_MaxMagn.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUP_MaxMagn.Name = "numUP_MaxMagn";
            this.numUP_MaxMagn.Size = new System.Drawing.Size(55, 21);
            this.numUP_MaxMagn.TabIndex = 2;
            this.numUP_MaxMagn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_MaxMagn.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numUP_MaxMagn.ValueChanged += new System.EventHandler(this.numUP_MaxMagn_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(193, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 10);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(391, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 10);
            this.label3.TabIndex = 1;
            this.label3.Text = "Min";
            // 
            // numUP_MaxFreq
            // 
            this.numUP_MaxFreq.Location = new System.Drawing.Point(222, 15);
            this.numUP_MaxFreq.Maximum = new decimal(new int[] {
            24000,
            0,
            0,
            0});
            this.numUP_MaxFreq.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUP_MaxFreq.Name = "numUP_MaxFreq";
            this.numUP_MaxFreq.Size = new System.Drawing.Size(55, 21);
            this.numUP_MaxFreq.TabIndex = 2;
            this.numUP_MaxFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_MaxFreq.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numUP_MaxFreq.ValueChanged += new System.EventHandler(this.numUP_MaxFreq_ValueChanged);
            // 
            // numUP_MinMagn
            // 
            this.numUP_MinMagn.Location = new System.Drawing.Point(420, 15);
            this.numUP_MinMagn.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUP_MinMagn.Minimum = new decimal(new int[] {
            160,
            0,
            0,
            -2147483648});
            this.numUP_MinMagn.Name = "numUP_MinMagn";
            this.numUP_MinMagn.Size = new System.Drawing.Size(55, 21);
            this.numUP_MinMagn.TabIndex = 0;
            this.numUP_MinMagn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_MinMagn.Value = new decimal(new int[] {
            80,
            0,
            0,
            -2147483648});
            this.numUP_MinMagn.ValueChanged += new System.EventHandler(this.numUP_MinMagn_ValueChanged);
            // 
            // numUP_MinFreq
            // 
            this.numUP_MinFreq.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUP_MinFreq.Location = new System.Drawing.Point(120, 15);
            this.numUP_MinFreq.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numUP_MinFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUP_MinFreq.Name = "numUP_MinFreq";
            this.numUP_MinFreq.Size = new System.Drawing.Size(55, 21);
            this.numUP_MinFreq.TabIndex = 0;
            this.numUP_MinFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_MinFreq.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUP_MinFreq.ValueChanged += new System.EventHandler(this.numUP_MinFreq_ValueChanged);
            // 
            // lbl_MinFreq
            // 
            this.lbl_MinFreq.AutoSize = true;
            this.lbl_MinFreq.Font = new System.Drawing.Font("SimSun", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MinFreq.Location = new System.Drawing.Point(91, 19);
            this.lbl_MinFreq.Name = "lbl_MinFreq";
            this.lbl_MinFreq.Size = new System.Drawing.Size(20, 10);
            this.lbl_MinFreq.TabIndex = 1;
            this.lbl_MinFreq.Text = "Min";
            // 
            // FilterSettingPanel
            // 
            this.FilterSettingPanel.BackColor = System.Drawing.Color.White;
            this.FilterSettingPanel.Controls.Add(this.dgv_filterSetting);
            this.FilterSettingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FilterSettingPanel.Location = new System.Drawing.Point(0, 376);
            this.FilterSettingPanel.Name = "FilterSettingPanel";
            this.FilterSettingPanel.Size = new System.Drawing.Size(775, 164);
            this.FilterSettingPanel.TabIndex = 3;
            // 
            // dgv_filterSetting
            // 
            this.dgv_filterSetting.AllowUserToAddRows = false;
            this.dgv_filterSetting.AllowUserToDeleteRows = false;
            this.dgv_filterSetting.AllowUserToResizeColumns = false;
            this.dgv_filterSetting.AllowUserToResizeRows = false;
            this.dgv_filterSetting.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_filterSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_filterSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_filterSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Type,
            this.SubType,
            this.Freq,
            this.Gain,
            this.BandWidth,
            this.QFactor,
            this.View,
            this.Bypass,
            this.CurveColor});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_filterSetting.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_filterSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_filterSetting.Location = new System.Drawing.Point(0, 0);
            this.dgv_filterSetting.MultiSelect = false;
            this.dgv_filterSetting.Name = "dgv_filterSetting";
            this.dgv_filterSetting.RowHeadersVisible = false;
            this.dgv_filterSetting.RowTemplate.Height = 23;
            this.dgv_filterSetting.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_filterSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_filterSetting.Size = new System.Drawing.Size(775, 164);
            this.dgv_filterSetting.TabIndex = 1;
            this.dgv_filterSetting.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_filterSetting_CellFormatting);
            this.dgv_filterSetting.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_filterSetting_CellValidating);
            this.dgv_filterSetting.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_filterSetting_CellValueChanged);
            this.dgv_filterSetting.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_filterSetting_CurrentCellDirtyStateChanged);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No.DefaultCellStyle = dataGridViewCellStyle2;
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.No.Width = 29;
            // 
            // Type
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Type.DefaultCellStyle = dataGridViewCellStyle3;
            this.Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Type.HeaderText = "Type";
            this.Type.Items.AddRange(new object[] {
            "All Pass",
            "Test 1",
            "Test 2"});
            this.Type.Name = "Type";
            // 
            // SubType
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubType.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubType.HeaderText = "SubType";
            this.SubType.Name = "SubType";
            // 
            // Freq
            // 
            this.Freq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Freq.HeaderText = "Frequency (Hz)";
            this.Freq.Name = "Freq";
            this.Freq.Width = 114;
            // 
            // Gain
            // 
            this.Gain.HeaderText = "Gain (dB)";
            this.Gain.Name = "Gain";
            // 
            // BandWidth
            // 
            this.BandWidth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BandWidth.HeaderText = "BandWidth (Hz)";
            this.BandWidth.Name = "BandWidth";
            this.BandWidth.Width = 114;
            // 
            // QFactor
            // 
            this.QFactor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QFactor.HeaderText = "Q Factor";
            this.QFactor.Name = "QFactor";
            this.QFactor.Width = 78;
            // 
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.Width = 35;
            // 
            // Bypass
            // 
            this.Bypass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Bypass.HeaderText = "Bypass";
            this.Bypass.Name = "Bypass";
            this.Bypass.Width = 47;
            // 
            // CurveColor
            // 
            this.CurveColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CurveColor.HeaderText = "Color";
            this.CurveColor.Name = "CurveColor";
            this.CurveColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CurveColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CurveColor.Width = 41;
            // 
            // EQ_CurvePanel
            // 
            this.EQ_CurvePanel.BackColor = System.Drawing.Color.White;
            this.EQ_CurvePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EQ_CurvePanel.Location = new System.Drawing.Point(0, 46);
            this.EQ_CurvePanel.Name = "EQ_CurvePanel";
            this.EQ_CurvePanel.Size = new System.Drawing.Size(775, 330);
            this.EQ_CurvePanel.TabIndex = 4;
            this.EQ_CurvePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EQ_CurvePanel_Paint);
            // 
            // EQCurveCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.EQ_CurvePanel);
            this.Controls.Add(this.FilterSettingPanel);
            this.Controls.Add(this.pnl_EQCurveSetting);
            this.Name = "EQCurveCtrl";
            this.Size = new System.Drawing.Size(775, 540);
            this.pnl_EQCurveSetting.ResumeLayout(false);
            this.pnl_EQCurveSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MaxMagn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MaxFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MinMagn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MinFreq)).EndInit();
            this.FilterSettingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filterSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_EQCurveSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUP_MaxFreq;
        private System.Windows.Forms.Label lbl_MinFreq;
        private System.Windows.Forms.NumericUpDown numUP_MinFreq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUP_MaxMagn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUP_MinMagn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel FilterSettingPanel;
        private System.Windows.Forms.Panel EQ_CurvePanel;
        public System.Windows.Forms.DataGridView dgv_filterSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn SubType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gain;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn QFactor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn View;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bypass;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurveColor;
        private System.Windows.Forms.Button btn_Download_EQParam;

    }
}
