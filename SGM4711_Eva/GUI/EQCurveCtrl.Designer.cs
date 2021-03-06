﻿namespace SGM4711_Eva.GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_EQCurveSetting = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ImportEQ = new System.Windows.Forms.Button();
            this.btn_ExportEQ = new System.Windows.Forms.Button();
            this.chb_EQCurveView = new System.Windows.Forms.CheckBox();
            this.btn_Download_EQParam = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numUP_MaxMagn = new System.Windows.Forms.NumericUpDown();
            this.numUP_MinMagn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUP_MaxFreq = new System.Windows.Forms.NumericUpDown();
            this.lbl_MinFreq = new System.Windows.Forms.Label();
            this.numUP_MinFreq = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MaxMagn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MinMagn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MaxFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MinFreq)).BeginInit();
            this.FilterSettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filterSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_EQCurveSetting
            // 
            this.pnl_EQCurveSetting.BackColor = System.Drawing.Color.White;
            this.pnl_EQCurveSetting.Controls.Add(this.groupBox3);
            this.pnl_EQCurveSetting.Controls.Add(this.groupBox2);
            this.pnl_EQCurveSetting.Controls.Add(this.groupBox1);
            this.pnl_EQCurveSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_EQCurveSetting.Location = new System.Drawing.Point(0, 0);
            this.pnl_EQCurveSetting.Name = "pnl_EQCurveSetting";
            this.pnl_EQCurveSetting.Size = new System.Drawing.Size(776, 72);
            this.pnl_EQCurveSetting.TabIndex = 1;
            this.pnl_EQCurveSetting.SizeChanged += new System.EventHandler(this.pnl_EQCurveSetting_SizeChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ImportEQ);
            this.groupBox3.Controls.Add(this.btn_ExportEQ);
            this.groupBox3.Controls.Add(this.chb_EQCurveView);
            this.groupBox3.Controls.Add(this.btn_Download_EQParam);
            this.groupBox3.Location = new System.Drawing.Point(463, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 60);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Functions";
            // 
            // btn_ImportEQ
            // 
            this.btn_ImportEQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ImportEQ.Location = new System.Drawing.Point(10, 20);
            this.btn_ImportEQ.Name = "btn_ImportEQ";
            this.btn_ImportEQ.Size = new System.Drawing.Size(55, 23);
            this.btn_ImportEQ.TabIndex = 9;
            this.btn_ImportEQ.Text = "Import";
            this.btn_ImportEQ.UseVisualStyleBackColor = true;
            this.btn_ImportEQ.Click += new System.EventHandler(this.btn_ImportEQ_Click);
            // 
            // btn_ExportEQ
            // 
            this.btn_ExportEQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ExportEQ.Location = new System.Drawing.Point(71, 20);
            this.btn_ExportEQ.Name = "btn_ExportEQ";
            this.btn_ExportEQ.Size = new System.Drawing.Size(55, 23);
            this.btn_ExportEQ.TabIndex = 10;
            this.btn_ExportEQ.Text = "Export";
            this.btn_ExportEQ.UseVisualStyleBackColor = true;
            this.btn_ExportEQ.Click += new System.EventHandler(this.btn_ExportEQ_Click);
            // 
            // chb_EQCurveView
            // 
            this.chb_EQCurveView.AutoSize = true;
            this.chb_EQCurveView.Checked = true;
            this.chb_EQCurveView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_EQCurveView.Location = new System.Drawing.Point(150, 23);
            this.chb_EQCurveView.Name = "chb_EQCurveView";
            this.chb_EQCurveView.Size = new System.Drawing.Size(66, 16);
            this.chb_EQCurveView.TabIndex = 8;
            this.chb_EQCurveView.Text = "EQ View";
            this.chb_EQCurveView.UseVisualStyleBackColor = true;
            this.chb_EQCurveView.CheckedChanged += new System.EventHandler(this.chb_EQCurveView_CheckedChanged);
            // 
            // btn_Download_EQParam
            // 
            this.btn_Download_EQParam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Download_EQParam.Location = new System.Drawing.Point(222, 20);
            this.btn_Download_EQParam.Name = "btn_Download_EQParam";
            this.btn_Download_EQParam.Size = new System.Drawing.Size(75, 23);
            this.btn_Download_EQParam.TabIndex = 6;
            this.btn_Download_EQParam.Text = "Download";
            this.btn_Download_EQParam.UseVisualStyleBackColor = true;
            this.btn_Download_EQParam.Click += new System.EventHandler(this.btn_Download_EQParam_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numUP_MaxMagn);
            this.groupBox2.Controls.Add(this.numUP_MinMagn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(233, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 60);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Magnitude (dB)";
            // 
            // numUP_MaxMagn
            // 
            this.numUP_MaxMagn.Location = new System.Drawing.Point(143, 22);
            this.numUP_MaxMagn.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUP_MaxMagn.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            -2147483648});
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
            // numUP_MinMagn
            // 
            this.numUP_MinMagn.Location = new System.Drawing.Point(41, 22);
            this.numUP_MinMagn.Maximum = new decimal(new int[] {
            30,
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 10);
            this.label3.TabIndex = 1;
            this.label3.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(114, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 10);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUP_MaxFreq);
            this.groupBox1.Controls.Add(this.lbl_MinFreq);
            this.groupBox1.Controls.Add(this.numUP_MinFreq);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 60);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frequency (Hz)";
            // 
            // numUP_MaxFreq
            // 
            this.numUP_MaxFreq.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUP_MaxFreq.Location = new System.Drawing.Point(143, 22);
            this.numUP_MaxFreq.Maximum = new decimal(new int[] {
            24000,
            0,
            0,
            0});
            this.numUP_MaxFreq.Minimum = new decimal(new int[] {
            1,
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
            // lbl_MinFreq
            // 
            this.lbl_MinFreq.AutoSize = true;
            this.lbl_MinFreq.Font = new System.Drawing.Font("SimSun", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MinFreq.Location = new System.Drawing.Point(12, 27);
            this.lbl_MinFreq.Name = "lbl_MinFreq";
            this.lbl_MinFreq.Size = new System.Drawing.Size(20, 10);
            this.lbl_MinFreq.TabIndex = 1;
            this.lbl_MinFreq.Text = "Min";
            // 
            // numUP_MinFreq
            // 
            this.numUP_MinFreq.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUP_MinFreq.Location = new System.Drawing.Point(41, 22);
            this.numUP_MinFreq.Maximum = new decimal(new int[] {
            24000,
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(114, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 10);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max";
            // 
            // FilterSettingPanel
            // 
            this.FilterSettingPanel.BackColor = System.Drawing.Color.White;
            this.FilterSettingPanel.Controls.Add(this.dgv_filterSetting);
            this.FilterSettingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FilterSettingPanel.Location = new System.Drawing.Point(0, 411);
            this.FilterSettingPanel.Name = "FilterSettingPanel";
            this.FilterSettingPanel.Size = new System.Drawing.Size(776, 163);
            this.FilterSettingPanel.TabIndex = 3;
            // 
            // dgv_filterSetting
            // 
            this.dgv_filterSetting.AllowUserToAddRows = false;
            this.dgv_filterSetting.AllowUserToDeleteRows = false;
            this.dgv_filterSetting.AllowUserToResizeColumns = false;
            this.dgv_filterSetting.AllowUserToResizeRows = false;
            this.dgv_filterSetting.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_filterSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
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
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_filterSetting.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgv_filterSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_filterSetting.Location = new System.Drawing.Point(0, 0);
            this.dgv_filterSetting.MultiSelect = false;
            this.dgv_filterSetting.Name = "dgv_filterSetting";
            this.dgv_filterSetting.RowHeadersVisible = false;
            this.dgv_filterSetting.RowTemplate.Height = 23;
            this.dgv_filterSetting.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_filterSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_filterSetting.Size = new System.Drawing.Size(776, 163);
            this.dgv_filterSetting.TabIndex = 1;
            this.dgv_filterSetting.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_filterSetting_CellFormatting);
            this.dgv_filterSetting.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_filterSetting_CellValidating);
            this.dgv_filterSetting.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_filterSetting_CellValueChanged);
            this.dgv_filterSetting.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_filterSetting_CurrentCellDirtyStateChanged);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No.DefaultCellStyle = dataGridViewCellStyle32;
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.No.Width = 29;
            // 
            // Type
            // 
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Type.DefaultCellStyle = dataGridViewCellStyle33;
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
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubType.DefaultCellStyle = dataGridViewCellStyle34;
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
            this.EQ_CurvePanel.Location = new System.Drawing.Point(0, 72);
            this.EQ_CurvePanel.Name = "EQ_CurvePanel";
            this.EQ_CurvePanel.Size = new System.Drawing.Size(776, 339);
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
            this.Size = new System.Drawing.Size(776, 574);
            this.pnl_EQCurveSetting.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MaxMagn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MinMagn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_MaxFreq)).EndInit();
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
        private System.Windows.Forms.CheckBox chb_EQCurveView;
        private System.Windows.Forms.Button btn_ExportEQ;
        private System.Windows.Forms.Button btn_ImportEQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}
