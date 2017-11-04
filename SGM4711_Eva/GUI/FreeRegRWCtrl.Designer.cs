namespace SGM4711_Eva.GUI
{
    partial class FreeRegRWCtrl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_regSetting = new System.Windows.Forms.DataGridView();
            this.btn_WriteAllReg = new System.Windows.Forms.Button();
            this.pl_RegOperation = new System.Windows.Forms.Panel();
            this.lbl_RowCount = new System.Windows.Forms.Label();
            this.numUP_RowCount = new System.Windows.Forms.NumericUpDown();
            this.btn_ReadAllReg = new System.Windows.Forms.Button();
            this.regAddrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_regSetting)).BeginInit();
            this.pl_RegOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_RowCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_regSetting
            // 
            this.dgv_regSetting.AllowUserToAddRows = false;
            this.dgv_regSetting.AllowUserToDeleteRows = false;
            this.dgv_regSetting.AllowUserToResizeColumns = false;
            this.dgv_regSetting.AllowUserToResizeRows = false;
            this.dgv_regSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_regSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_regSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_regSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regAddrColumn,
            this.regDataColumn,
            this.updateColumn});
            this.dgv_regSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_regSetting.Location = new System.Drawing.Point(0, 0);
            this.dgv_regSetting.Name = "dgv_regSetting";
            this.dgv_regSetting.RowHeadersVisible = false;
            this.dgv_regSetting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_regSetting.RowTemplate.Height = 23;
            this.dgv_regSetting.Size = new System.Drawing.Size(378, 341);
            this.dgv_regSetting.TabIndex = 4;
            this.dgv_regSetting.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_regSetting_CellFormatting);
            this.dgv_regSetting.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_regSetting_CurrentCellDirtyStateChanged);
            this.dgv_regSetting.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_regSetting_EditingControlShowing);
            this.dgv_regSetting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_regSetting_KeyPress);
            // 
            // btn_WriteAllReg
            // 
            this.btn_WriteAllReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_WriteAllReg.AutoSize = true;
            this.btn_WriteAllReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WriteAllReg.Location = new System.Drawing.Point(14, 102);
            this.btn_WriteAllReg.Name = "btn_WriteAllReg";
            this.btn_WriteAllReg.Size = new System.Drawing.Size(71, 24);
            this.btn_WriteAllReg.TabIndex = 1;
            this.btn_WriteAllReg.Text = "Write All";
            this.btn_WriteAllReg.UseVisualStyleBackColor = true;
            this.btn_WriteAllReg.Click += new System.EventHandler(this.btn_WriteAllReg_Click);
            // 
            // pl_RegOperation
            // 
            this.pl_RegOperation.Controls.Add(this.lbl_RowCount);
            this.pl_RegOperation.Controls.Add(this.numUP_RowCount);
            this.pl_RegOperation.Controls.Add(this.btn_WriteAllReg);
            this.pl_RegOperation.Controls.Add(this.btn_ReadAllReg);
            this.pl_RegOperation.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_RegOperation.Location = new System.Drawing.Point(378, 0);
            this.pl_RegOperation.Name = "pl_RegOperation";
            this.pl_RegOperation.Size = new System.Drawing.Size(95, 341);
            this.pl_RegOperation.TabIndex = 3;
            // 
            // lbl_RowCount
            // 
            this.lbl_RowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RowCount.AutoSize = true;
            this.lbl_RowCount.Location = new System.Drawing.Point(12, 6);
            this.lbl_RowCount.Name = "lbl_RowCount";
            this.lbl_RowCount.Size = new System.Drawing.Size(35, 12);
            this.lbl_RowCount.TabIndex = 3;
            this.lbl_RowCount.Text = "Count";
            // 
            // numUP_RowCount
            // 
            this.numUP_RowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUP_RowCount.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numUP_RowCount.Location = new System.Drawing.Point(14, 21);
            this.numUP_RowCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUP_RowCount.Name = "numUP_RowCount";
            this.numUP_RowCount.Size = new System.Drawing.Size(71, 21);
            this.numUP_RowCount.TabIndex = 2;
            this.numUP_RowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUP_RowCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUP_RowCount.ValueChanged += new System.EventHandler(this.numUP_RowCount_ValueChanged);
            // 
            // btn_ReadAllReg
            // 
            this.btn_ReadAllReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReadAllReg.AutoSize = true;
            this.btn_ReadAllReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReadAllReg.Location = new System.Drawing.Point(14, 61);
            this.btn_ReadAllReg.Name = "btn_ReadAllReg";
            this.btn_ReadAllReg.Size = new System.Drawing.Size(71, 24);
            this.btn_ReadAllReg.TabIndex = 0;
            this.btn_ReadAllReg.Text = "Read All";
            this.btn_ReadAllReg.UseVisualStyleBackColor = true;
            this.btn_ReadAllReg.Click += new System.EventHandler(this.btn_ReadAllReg_Click);
            // 
            // regAddrColumn
            // 
            this.regAddrColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.regAddrColumn.HeaderText = "Register Address";
            this.regAddrColumn.Name = "regAddrColumn";
            this.regAddrColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // regDataColumn
            // 
            this.regDataColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.regDataColumn.HeaderText = "Register Data";
            this.regDataColumn.Name = "regDataColumn";
            this.regDataColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // updateColumn
            // 
            this.updateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.updateColumn.FillWeight = 50F;
            this.updateColumn.HeaderText = "Actived";
            this.updateColumn.Name = "updateColumn";
            // 
            // FreeRegRWCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_regSetting);
            this.Controls.Add(this.pl_RegOperation);
            this.Name = "FreeRegRWCtrl";
            this.Size = new System.Drawing.Size(473, 341);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_regSetting)).EndInit();
            this.pl_RegOperation.ResumeLayout(false);
            this.pl_RegOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_RowCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_regSetting;
        public System.Windows.Forms.Button btn_WriteAllReg;
        private System.Windows.Forms.Panel pl_RegOperation;
        public System.Windows.Forms.Button btn_ReadAllReg;
        private System.Windows.Forms.Label lbl_RowCount;
        private System.Windows.Forms.NumericUpDown numUP_RowCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn regAddrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDataColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn updateColumn;
    }
}
