using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MD.MDCommon;
using DMCommunication;

namespace SGM4711_Eva.GUI
{
    [Serializable]
    public partial class RegSettingCtrl : UserControl
    {
        RegisterMap regMap;
        DMDongle dongle;
        IRegOperation myRegOp;
        public RegSettingCtrl(DMDongle _dongle, IRegOperation _myRegOp)
        {
            InitializeComponent();
            this.myRegOp = _myRegOp;
            this.dongle = _dongle;
            DataGridViewInit();
        }

        public RegSettingCtrl(BindingList<RegProperty> _blist)
        {
            InitializeComponent();

            DataGridViewInit();
            //dataGridView1.Columns.Add(test);

            dgv_regSetting.DataSource = _blist;
        }

        public void UpdateRegMap(RegisterMap _regmap)
        {
            this.regMap = _regmap;
            UpdateGUI();
        }

        public void UpdateDataSource(BindingList<RegProperty> _blist)
        {
            if (_blist.Count == 0)
            {
                this.btn_ReadReg.Enabled = false;
                this.btn_WriteReg.Enabled = false;
            }
            else
            {
                this.btn_ReadReg.Enabled = true;
                this.btn_WriteReg.Enabled = true; 
            }
            dgv_regSetting.DataSource = _blist;            
        }

        private void DataGridViewInit()
        {
            dgv_regSetting.AutoGenerateColumns = false;
            //dgv_regSetting.AutoSize = true;
            //dgv_regSetting.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);
            //dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

            DataGridViewTextBoxColumn regAddrColumn = new DataGridViewTextBoxColumn();
            regAddrColumn.DataPropertyName = "regAddr";
            //regAddrColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            regAddrColumn.HeaderText = "Addr(H2)";
            regAddrColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            regAddrColumn.DefaultCellStyle.Format = "X2";
            regAddrColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            regAddrColumn.ReadOnly = true;
            regAddrColumn.Selected = false;
            regAddrColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //regAddrColumn.FillWeight = 100;

            DataGridViewTextBoxColumn reg_bfNameColumn = new DataGridViewTextBoxColumn();
            reg_bfNameColumn.DataPropertyName = "reg_bfName";
            //regDataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            reg_bfNameColumn.HeaderText = "Reg/BF Name";
            reg_bfNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            //reg_bfNameColumn.DefaultCellStyle.Format = "X8";
            reg_bfNameColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //regDataColumn.ReadOnly = true;
            reg_bfNameColumn.Selected = false;
            reg_bfNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //regAddrColumn.FillWeight = 100;

            DataGridViewTextBoxColumn regDataColumn = new DataGridViewTextBoxColumn();
            regDataColumn.DataPropertyName = "regData";
            //regDataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            regDataColumn.HeaderText = "RegValue(Hex)";
            regDataColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            regDataColumn.DefaultCellStyle.Format = "X";
            regDataColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //regDataColumn.ReadOnly = true;
            regDataColumn.Selected = false;
            regDataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //regAddrColumn.FillWeight = 100;

            //DataGridViewButtonColumn test = new DataGridViewButtonColumn();
            //test.DataPropertyName = "test";
            //test.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //test.HeaderText = "Test R";
            //test.SortMode = DataGridViewColumnSortMode.NotSortable;
            //test.Selected = false;
            //test.Text = "asfds";
            //test.Name = "fasdfsa";



            dgv_regSetting.Columns.Add(regAddrColumn);
            dgv_regSetting.Columns.Add(reg_bfNameColumn);
            dgv_regSetting.Columns.Add(regDataColumn);
        }

        private void UpdateGUI()
        {
            if (regMap != null && this.dgv_regSetting.Rows.Count > 0)
            {
                byte tempRegAddr = 0;
                for (int ix = 0; ix < dgv_regSetting.Rows.Count; ix++)
                {
                    // update register value
                    if (dgv_regSetting[0, ix].Value != "")
                    {
                        tempRegAddr = byte.Parse(dgv_regSetting[0, ix].Value.ToString(), NumberStyles.HexNumber);
                        dgv_regSetting[2, ix].Value = regMap[tempRegAddr].RegValueString;
                    }
                    // update bit filed value
                    else
                    {
                        string bfName = dgv_regSetting[1,ix].Value.ToString();
                        dgv_regSetting[2, ix].Value = regMap[tempRegAddr][bfName].BFValue;
                    }
                } 
            }
        }

        private void btn_ReadReg_Click(object sender, EventArgs e)
        {
            //RegSettingCtrl_ReadEvent(
        }

        private void btn_WriteReg_Click(object sender, EventArgs e)
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
            if ((e.Value == ""))
            {
                dgv_regSetting[e.ColumnIndex, e.RowIndex].ReadOnly = true;
                return;
            }
            else if (e.Value != null && e.ColumnIndex != 1)
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
            byte tempAddr = 0;
            int tempIx;
            DataGridViewRow tempRow = dgv_regSetting.Rows[e.RowIndex];
            switch (e.ColumnIndex)
            {
                case 2:         //Reg Value changed
                    // Update regmap and BF value in GUI display
                    //tempAddr = byte.Parse(tempRow.Cells[0].Value.ToString().Replace("0x", ""), NumberStyles.HexNumber);
                    //regMap[tempAddr].RegValue = UInt32.Parse(tempRow.Cells[1].Value.ToString().Replace("0x", ""), NumberStyles.HexNumber);

                    // Changing bit field value -> needs update reg value 
                    if (dgv_regSetting[0, e.RowIndex].Value.ToString() == "")
                    {
                        tempIx = e.RowIndex;
                        while (tempIx-- > 0)
                        {
                            if (dgv_regSetting[0, tempIx].Value.ToString() != "")
                            {
                                tempAddr = Byte.Parse(dgv_regSetting[0, tempIx].Value.ToString().Replace("0x", ""), NumberStyles.HexNumber);
                                break;
                            }
                        }
                        // Update bit field value and reg value on GUI
                        regMap[tempAddr].SetBFValue(dgv_regSetting[1, e.RowIndex].Value.ToString(),
                            dgv_regSetting[2, e.RowIndex].Value.ToString().Replace("0x", ""));
                        if(regMap[tempAddr].ByteCount <= 4 )
                            dgv_regSetting[2, tempIx].Value = regMap[tempAddr].RegValueString;

                    }
                    else
                    { }

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
            if (this.dgv_regSetting.CurrentCell.ColumnIndex == 2)
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

    }
}
