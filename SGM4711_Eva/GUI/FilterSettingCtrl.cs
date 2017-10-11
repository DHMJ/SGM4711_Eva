using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGM4711_Eva.MDCommon.Filter;

namespace SGM4711_Eva.GUI
{
    public partial class FilterSettingCtrl : UserControl
    {
        /* Settings: No. Type SubType Frequency Gain BandWidth QFactor View Bypass Color */
        List<FilterSetting> settings = new List<FilterSetting> { };
        public FilterSettingCtrl()
        {
            InitializeComponent();            
            InitDVG();
        }

        private void InitDVG()
        {
            //dgv_filterSetting.ShowCellToolTips = true;

            dgv_filterSetting.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_filterSetting.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // No.
            dgv_filterSetting.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_filterSetting.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[0].HeaderText = "No.";
            dgv_filterSetting.Columns[0].ReadOnly = true;
            // Filter Type
            //DataGridViewComboBoxColumn dgvCmbCloumn = new DataGridViewComboBoxColumn();
            //dgvCmbCloumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            //dgvCmbCloumn.FlatStyle = FlatStyle.Flat;
            //dgv_filterSetting.Columns.RemoveAt(1);
            //dgv_filterSetting.Columns.Insert(1, dgvCmbCloumn);
            dgv_filterSetting.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_filterSetting.Columns[1].Width = 150;
            dgv_filterSetting.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[1].HeaderText = "Filter Type";
            //dgv_filterSetting.Columns[1].CellType = new DataGridViewComboBoxColumn();
            (dgv_filterSetting.Columns[1] as DataGridViewComboBoxColumn).Items.Clear();
            (dgv_filterSetting.Columns[1] as DataGridViewComboBoxColumn).Items.Add(FilterType.AllPass.ToString());
            (dgv_filterSetting.Columns[1] as DataGridViewComboBoxColumn).Items.Add(FilterType.HighPass.ToString());
            (dgv_filterSetting.Columns[1] as DataGridViewComboBoxColumn).Items.Add(FilterType.LowPass.ToString());
            (dgv_filterSetting.Columns[1] as DataGridViewComboBoxColumn).Items.Add(FilterType.Peaking.ToString());
            (dgv_filterSetting.Columns[1] as DataGridViewComboBoxColumn).Items.Add(FilterType.Shelving.ToString());



            // Filter SubType
            dgv_filterSetting.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_filterSetting.Columns[2].Width = 150;
            dgv_filterSetting.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[2].HeaderText = "Filter SubType";
            (dgv_filterSetting.Columns[2] as DataGridViewComboBoxColumn).Items.Clear();
            (dgv_filterSetting.Columns[2] as DataGridViewComboBoxColumn).Items.Add(FilterSubType.None.ToString());
            (dgv_filterSetting.Columns[2] as DataGridViewComboBoxColumn).Items.Add(FilterSubType.Bessel.ToString());
            (dgv_filterSetting.Columns[2] as DataGridViewComboBoxColumn).Items.Add(FilterSubType.Butterworth.ToString());
            (dgv_filterSetting.Columns[2] as DataGridViewComboBoxColumn).Items.Add(FilterSubType.General.ToString());
            (dgv_filterSetting.Columns[2] as DataGridViewComboBoxColumn).Items.Add(FilterSubType.High.ToString());
            (dgv_filterSetting.Columns[2] as DataGridViewComboBoxColumn).Items.Add(FilterSubType.Low.ToString());



            // Frequency (Hz)
            dgv_filterSetting.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_filterSetting.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[3].HeaderText = "Frequency (Hz)";
            
            // Gain (dB)
            dgv_filterSetting.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_filterSetting.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[4].HeaderText = "Gain (dB)";
            
            // BandWidth (Hz)
            dgv_filterSetting.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_filterSetting.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[5].HeaderText = "BandWidth (Hz)";

            // Q Factor
            dgv_filterSetting.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_filterSetting.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[6].HeaderText = "Q Factor";

            // View
            dgv_filterSetting.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_filterSetting.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[7].HeaderText = "View";
            
            // Bypass
            dgv_filterSetting.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_filterSetting.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[8].HeaderText = "Bypass";

            // Color
            //DataGridViewButtonColumn dgvBtnCloumn = new DataGridViewButtonColumn();
            //dgvBtnCloumn.= 5;
            //dgvBtnCloumn.
            //dgv_filterSetting.Columns.RemoveAt(9);
            //dgv_filterSetting.Columns.Insert(9, dgvBtnCloumn);
            dgv_filterSetting.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_filterSetting.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[9].HeaderText = "Color";
            dgv_filterSetting.Columns[9].ReadOnly = true;
        }

        public void InitSetting(int count)
        {
            settings.Clear();
            for (int ix = 0; ix < count; ix++)
            {                
                settings.Add(new FilterSetting(ix, FilterCurveColor.FilterCurveColors(ix)));
            }

            this.dgv_filterSetting.Rows.Clear();
            for (int ix = 0; ix < settings.Count; ix++)
            {
                this.dgv_filterSetting.Rows.Add(new object[] { settings[ix].No.ToString(), settings[ix].Type.ToString(), 
                    settings[ix].SubType.ToString(), settings[ix].Freq.ToString("F2"), settings[ix].Gain.ToString("F2"), 
                settings[ix].BandWidth.ToString("F2"), settings[ix].QFactor.ToString("F3"), settings[ix].View, settings[ix].Bypass, "" });
               
                //Set Color
                this.dgv_filterSetting[9, ix].Style.BackColor = settings[ix].CurveColor;
                this.dgv_filterSetting[9, ix].Style.SelectionBackColor = settings[ix].CurveColor;
            }
        }

        private void dgv_filterSetting_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_filterSetting_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if ((e.Value == ""))
            //{
            //    dgv_regSetting[e.ColumnIndex, e.RowIndex].ReadOnly = true;
            //    return;
            //}
            //else if (e.Value != null && e.ColumnIndex != 1)
            //    e.Value = "0x" + e.Value.ToString().Replace("0x", "");            
        }

        /* Settings: No. Type SubType Frequency Gain BandWidth QFactor View Bypass Color */
        enum paramIx
        {
            No      = 0,
            Type    = 1,
            SubType = 2,
            Freq    = 3,
            Gain    = 4,
            BW      = 5,
            QFatcor = 6,
            View    = 7,
            Bypass  = 8,
            Color   = 9
        }

        /// <summary>
        /// This event will be used to verify if inputs in correct formate. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_filterSetting_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            double tempData;
            DataGridViewRow tempRow = dgv_filterSetting.Rows[e.RowIndex];
            if (e.ColumnIndex <= (int)paramIx.No || e.ColumnIndex >= (int)paramIx.Color)
                return;

            switch (e.ColumnIndex)
            {
                case (int)paramIx.Freq:
                    break;

                case (int)paramIx.Gain:
                    break;

                case (int)paramIx.BW:
                    break;

                case (int)paramIx.QFatcor:
                    break;

                default:
                    break;

            }
        }
    }    
}
