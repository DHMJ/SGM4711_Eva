using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MD.MDCommon;
using System.Globalization;
using DMCommunication;

namespace SGM4711_Eva.GUI
{
    [Serializable]
    public partial class FreeRegRWCtrl : UserControl
    {
        RegisterMap regMap;
        IRegOperation myRegOp;
        DMDongle dongle;
        List<byte> regAddrList = new List<byte> { };
        List<uint> regDataList = new List<uint> { };
        List<bool> activedEnList = new List<bool> { };
        int totalCount = 0;
        public FreeRegRWCtrl(IRegOperation _myRegOp, DMDongle _dongle)
        {
            InitializeComponent();
            this.myRegOp = _myRegOp;
            this.dongle = _dongle;
            DataGridViewInit();
            InitGUI();
        }

        public void UpdateRegMap(RegisterMap _regmap)
        {
            this.regMap = _regmap;
            UpdateGUI();
        }

        public List<byte> RegAddrList
        {
            get { return this.regAddrList; }
        }

        public List<bool> ActivedEnList
        {
            get { return this.activedEnList; }
        }

        public int TotalCount
        {
            get { return totalCount; }
        }

        private void UpdateGUI()
        {
            if (regMap != null && this.dgv_regSetting.Rows.Count > 0)
            {
                byte tempRegAddr = 0;
                for (int ix = 0; ix < dgv_regSetting.Rows.Count; ix++)
                {
                    // update register value
                    if (dgv_regSetting[0, ix].Value.ToString() != "")
                    {
                        tempRegAddr = byte.Parse(dgv_regSetting[0, ix].Value.ToString(), NumberStyles.HexNumber);
                        dgv_regSetting[1, ix].Value = regMap[tempRegAddr].RegValueString;
                    }
                    // update bit filed value
                    else
                    {
                        string bfName = dgv_regSetting[1, ix].Value.ToString();
                        dgv_regSetting[2, ix].Value = regMap[tempRegAddr][bfName].BFValue;
                    }
                }
            }
        }

        private void DataGridViewInit()
        {
            dgv_regSetting.AutoGenerateColumns = false;
            //dgv_regSetting.AutoSize = true;
            //dgv_regSetting.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);
            //dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

            DataGridViewTextBoxColumn regAddrColumn = (DataGridViewTextBoxColumn)dgv_regSetting.Columns[0];
            regAddrColumn.DataPropertyName = "regAddr";
            //regAddrColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            regAddrColumn.HeaderText = "Reg Address";
            regAddrColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            regAddrColumn.DefaultCellStyle.Format = "X2";
            regAddrColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            regAddrColumn.ReadOnly = false;
            regAddrColumn.Selected = false;
            //regAddrColumn.FillWeight = 50;

            DataGridViewTextBoxColumn regDataColumn = (DataGridViewTextBoxColumn)dgv_regSetting.Columns[1];
            regDataColumn.DataPropertyName = "regData";
            //regDataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            regDataColumn.HeaderText = "Reg Data";
            regDataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            regDataColumn.DefaultCellStyle.Format = "X";
            regDataColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            regDataColumn.ReadOnly = false;
            regDataColumn.Selected = false;
            //regAddrColumn.FillWeight = 50;

            DataGridViewCheckBoxColumn ifUpdate = (DataGridViewCheckBoxColumn)dgv_regSetting.Columns[2];
            ifUpdate.DataPropertyName = "ifUpdate";
            ifUpdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ifUpdate.HeaderText = "update";
            ifUpdate.SortMode = DataGridViewColumnSortMode.NotSortable;
            ifUpdate.Selected = false;
            ifUpdate.Name = "ifUpdate";

            //DataGridViewButtonColumn regRead = new DataGridViewButtonColumn();
            //regRead.DataPropertyName = "Read";
            //regRead.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //regRead.HeaderText = "Read";
            //regRead.SortMode = DataGridViewColumnSortMode.NotSortable;
            //regRead.Selected = false;
            //regRead.Text = "regRead";
            //regRead.Name = "regRead";
            //regRead.FillWeight = 50;

            //DataGridViewButtonColumn regWrite = new DataGridViewButtonColumn();
            //regWrite.DataPropertyName = "Write";
            //regWrite.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //regWrite.HeaderText = "Write";
            //regWrite.SortMode = DataGridViewColumnSortMode.NotSortable;
            //regWrite.Selected = false;
            //regWrite.Text = "regWrite";
            //regWrite.Name = "regWrite";
            //regWrite.FillWeight = 50;

            //dgv_regSetting.Columns.Add(regAddrColumn);
            //dgv_regSetting.Columns.Add(regDataColumn);
            //dgv_regSetting.Columns.Add(ifUpdate);
            //dgv_regSetting.Columns.Add(regWrite);

            dgv_regSetting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_regSetting.Columns[0].FillWeight = 100;
            dgv_regSetting.Columns[1].FillWeight = 100;
            dgv_regSetting.Columns[2].FillWeight = 100;
            //dgv_regSetting.Columns[3].FillWeight = 50;
            //dgv_regSetting.Rows.Add("1");
        }

        private void InitGUI()
        {
            totalCount = (int)this.numUP_RowCount.Value;
            this.dgv_regSetting.Rows.Add(totalCount);
            uint tempRegValue = 0;
           
            for (int ix = 0; ix < dgv_regSetting.Rows.Count; ix++)
            {
                if (regMap != null)
                    tempRegValue = regMap[(byte)ix].RegValue;

                dgv_regSetting[0, ix].Value = ix;
                regAddrList.Add((byte)ix);
                //regAddrList[ix] = 0x00;
                dgv_regSetting[1, ix].Value = tempRegValue.ToString("X");
                regDataList.Add(tempRegValue);
                //regDataList[ix] = tempRegValue;
                dgv_regSetting[2, ix].Value = true;
                activedEnList.Add(true);
                //updateEnList[ix] = true;
            }
            this.dgv_regSetting.CellValueChanged += new DataGridViewCellEventHandler(dgv_regSetting_CellValueChanged);
        }

        private void btn_ReadAllReg_Click(object sender, EventArgs e)
        {
            for (int ix = 0; ix < activedEnList.Count; ix++)
            {
                if (activedEnList[ix])
                {
                    this.dgv_regSetting.Rows[ix].Cells[1].Value = regMap[RegAddrList[ix]].RegValueString;
                }
            }
        }

        private void btn_WriteAllReg_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Set the cell read only properity and "0x" prefix for hex data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_regSetting_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Just make the diplay value have a 0x prefix, real cell value is the value you enter in
            //int tempValue = int.Parse(e.Value.ToString());
            if ((e.Value != null) && e.ColumnIndex <= 1)
                e.Value = "0x" + e.Value.ToString().Replace("0x", "");
        }

        /// <summary>
        /// Refresh display status immediately 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_regSetting_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_regSetting.IsCurrentCellDirty)
            {
                //dgv_regSetting.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_regSetting_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            byte tempAddr;
            if (e.RowIndex < 0)
                return;
            DataGridViewRow tempRow = dgv_regSetting.Rows[e.RowIndex];
            switch (e.ColumnIndex)
            {
                case 0:         //Reg Address changed
                    // Update regmap and BF value in GUI display
                    tempAddr = byte.Parse(tempRow.Cells[0].Value.ToString().Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);
                    tempRow.Cells[1].Value = regMap[tempAddr].RegValueString;

                    //backup
                    regAddrList[e.RowIndex] = tempAddr;
                    //regDataList[e.RowIndex] = regMap[tempAddr].RegValue;

                    break;

                case 1:         //Reg Value changed
                    // Update regmap and BF value in GUI display
                    tempAddr = byte.Parse(tempRow.Cells[0].Value.ToString().Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);
                    regMap[tempAddr].RegValue = UInt32.Parse(tempRow.Cells[1].Value.ToString().Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);

                    //backup
                    //regAddrList[e.RowIndex] = tempAddr;
                    regDataList[e.RowIndex] = regMap[tempAddr].RegValue;

                    break;

                case 2:         //Reg Value changed
                    activedEnList[e.RowIndex] = (bool)tempRow.Cells[2].Value;
                    break;

                default:
                    break;
            }
        }

        private void dgv_regSetting_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox txt_Regx = sender as TextBox;
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            string str = "\r\b0123456789abcdefABCDEF";//This will allow the user to enter numeric HEX values only.

            e.Handled = !(str.Contains(e.KeyChar.ToString()));

            if (e.Handled)
                return;
        }

        private void dgv_regSetting_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dgv_regSetting.CurrentCell.ColumnIndex <= 1)
            {
                e.Control.KeyPress += new KeyPressEventHandler(EditingControl_KeyPress);
            }
        }

        private void EditingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            //This will allow the user to enter numeric HEX values only.
            string str = "\r\b0123456789abcdefABCDEF";

            e.Handled = !(str.Contains(e.KeyChar.ToString()));
        }

        private void numUP_RowCount_ValueChanged(object sender, EventArgs e)
        {
            totalCount = (int)numUP_RowCount.Value;
            int currentRowCount = this.dgv_regSetting.Rows.Count;
            //this.dgv_regSetting.Rows.Clear();
            if (totalCount < currentRowCount)
            {
                do
                {
                    this.dgv_regSetting.Rows.RemoveAt(--currentRowCount);
                }
                while (currentRowCount > totalCount);
            }
            else if (totalCount > currentRowCount)
            {
                for (int ix = currentRowCount; ix < totalCount; ix++)
                {
                    this.dgv_regSetting.Rows.Add(1);
                    if (ix < this.regAddrList.Count)
                    {
                        this.dgv_regSetting[0, ix].Value = regAddrList[ix].ToString("X2");
                        this.dgv_regSetting[1, ix].Value = regDataList[ix].ToString("X");
                        this.dgv_regSetting[2, ix].Value = activedEnList[ix];
                    }
                    else
                    {
                        regAddrList.Add(0);
                        regDataList.Add(0);
                        activedEnList.Add(true);
                        this.dgv_regSetting[0, ix].Value = "0";
                        this.dgv_regSetting[1, ix].Value = "0";
                        this.dgv_regSetting[2, ix].Value = true;
                    }
                }

            }
        }
    }
}
