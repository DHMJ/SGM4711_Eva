namespace SGM4711_Eva.GUI
{
    partial class RegSettingCtrl
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
            this.pl_RegOperation = new System.Windows.Forms.Panel();
            this.lbl_OpUnitName = new System.Windows.Forms.Label();
            this.btn_WriteReg = new System.Windows.Forms.Button();
            this.btn_ReadReg = new System.Windows.Forms.Button();
            this.dgv_regSetting = new System.Windows.Forms.DataGridView();
            this.pl_RegOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_regSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_RegOperation
            // 
            this.pl_RegOperation.Controls.Add(this.lbl_OpUnitName);
            this.pl_RegOperation.Controls.Add(this.btn_WriteReg);
            this.pl_RegOperation.Controls.Add(this.btn_ReadReg);
            this.pl_RegOperation.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_RegOperation.Location = new System.Drawing.Point(319, 0);
            this.pl_RegOperation.Name = "pl_RegOperation";
            this.pl_RegOperation.Size = new System.Drawing.Size(108, 261);
            this.pl_RegOperation.TabIndex = 1;
            // 
            // lbl_OpUnitName
            // 
            this.lbl_OpUnitName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_OpUnitName.AutoSize = true;
            this.lbl_OpUnitName.Location = new System.Drawing.Point(27, 19);
            this.lbl_OpUnitName.Name = "lbl_OpUnitName";
            this.lbl_OpUnitName.Size = new System.Drawing.Size(29, 12);
            this.lbl_OpUnitName.TabIndex = 2;
            this.lbl_OpUnitName.Text = "None";
            // 
            // btn_WriteReg
            // 
            this.btn_WriteReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_WriteReg.AutoSize = true;
            this.btn_WriteReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WriteReg.Location = new System.Drawing.Point(27, 99);
            this.btn_WriteReg.Name = "btn_WriteReg";
            this.btn_WriteReg.Size = new System.Drawing.Size(70, 24);
            this.btn_WriteReg.TabIndex = 1;
            this.btn_WriteReg.Text = "Write";
            this.btn_WriteReg.UseVisualStyleBackColor = true;
            this.btn_WriteReg.Click += new System.EventHandler(this.btn_WriteReg_Click);
            // 
            // btn_ReadReg
            // 
            this.btn_ReadReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReadReg.AutoSize = true;
            this.btn_ReadReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReadReg.Location = new System.Drawing.Point(27, 51);
            this.btn_ReadReg.Name = "btn_ReadReg";
            this.btn_ReadReg.Size = new System.Drawing.Size(70, 24);
            this.btn_ReadReg.TabIndex = 0;
            this.btn_ReadReg.Text = "Read";
            this.btn_ReadReg.UseVisualStyleBackColor = true;
            this.btn_ReadReg.Click += new System.EventHandler(this.btn_ReadReg_Click);
            // 
            // dgv_regSetting
            // 
            this.dgv_regSetting.AllowUserToAddRows = false;
            this.dgv_regSetting.AllowUserToDeleteRows = false;
            this.dgv_regSetting.AllowUserToResizeColumns = false;
            this.dgv_regSetting.AllowUserToResizeRows = false;
            this.dgv_regSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_regSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_regSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_regSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_regSetting.Location = new System.Drawing.Point(0, 0);
            this.dgv_regSetting.Name = "dgv_regSetting";
            this.dgv_regSetting.RowHeadersVisible = false;
            this.dgv_regSetting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_regSetting.RowTemplate.Height = 23;
            this.dgv_regSetting.Size = new System.Drawing.Size(319, 261);
            this.dgv_regSetting.TabIndex = 2;
            this.dgv_regSetting.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_regSetting_CellFormatting);
            this.dgv_regSetting.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_regSetting_CellValueChanged);
            this.dgv_regSetting.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_regSetting_CurrentCellDirtyStateChanged);
            this.dgv_regSetting.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_regSetting_EditingControlShowing);
            this.dgv_regSetting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_regSetting_KeyPress);
            // 
            // RegSettingCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_regSetting);
            this.Controls.Add(this.pl_RegOperation);
            this.Name = "RegSettingCtrl";
            this.Size = new System.Drawing.Size(427, 261);
            this.pl_RegOperation.ResumeLayout(false);
            this.pl_RegOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_regSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_RegOperation;
        private System.Windows.Forms.Button btn_WriteReg;
        private System.Windows.Forms.Button btn_ReadReg;
        private System.Windows.Forms.DataGridView dgv_regSetting;
        private System.Windows.Forms.Label lbl_OpUnitName;


    }
}
