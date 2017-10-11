namespace SGM4711_Eva.GUI
{
    partial class FilterSettingCtrl
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filterSetting)).BeginInit();
            this.SuspendLayout();
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
            this.dgv_filterSetting.Size = new System.Drawing.Size(791, 153);
            this.dgv_filterSetting.TabIndex = 0;
            this.dgv_filterSetting.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_filterSetting_CellFormatting);
            this.dgv_filterSetting.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_filterSetting_CellValidating);
            this.dgv_filterSetting.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_filterSetting_CellValueChanged);
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
            // FilterSettingCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_filterSetting);
            this.Name = "FilterSettingCtrl";
            this.Size = new System.Drawing.Size(791, 153);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filterSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}
