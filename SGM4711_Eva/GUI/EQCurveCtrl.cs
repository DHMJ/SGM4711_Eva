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
    public partial class EQCurveCtrl : UserControl
    {
        public EQCurveCtrl()
        {
            InitializeComponent();
            InitDVG();
        }

        #region Params
        int xAxis_Shift = 30;
        int yAxis_Shift = 30;

        // Frequency and Magnitude
        int MinFreq = 20;
        int MaxFreq = 20000;
        int MinMag = -80;
        int MaxMag = 40;

        // Log Axis steps
        double[] logAxisStep = new double[] {Math.Log(2), Math.Log(3) - Math.Log(2), Math.Log(4) - Math.Log(3),
            Math.Log(5) - Math.Log(4), Math.Log(6) - Math.Log(5), Math.Log(7) - Math.Log(6),
            Math.Log(8) - Math.Log(7), Math.Log(9) - Math.Log(8), Math.Log(10) - Math.Log(9)};

        /* Settings: No. Type SubType Frequency Gain BandWidth QFactor View Bypass Color */
        List<FilterSetting> settings = new List<FilterSetting> { };
        int filterCount = 1;
        #endregion Params
        
        #region Methods
        List<Point> xAxisPoint_1 = new List<Point> { };
        List<Point> xAxisPoint_2 = new List<Point> { };
        List<Point> yAxisPoint_1 = new List<Point> { };
        List<Point> yAxisPoint_2 = new List<Point> { };
        List<int> largGridIx_Freq = new List<int> { };
        List<int> GridIx_20dBMag = new List<int> { };
        List<string> xAxisString = new List<string> { };
        List<string> yAxisString = new List<string> { };
        List<Point> xAxisStringLoca = new List<Point> { };
        List<Point> yAxisStringLoca = new List<Point> { };
        //Pen pen_smallGrid = new Pen(Color.FromArgb(30, 30, 30), 1);
        //Pen pen_largeGrid = new Pen(Color.FromArgb(50, 50, 50), 1);
        Pen pen_smallGrid = new Pen(Color.LightGray, 1);
        Pen pen_largeGrid = new Pen(Color.Gray, 1);
        static int frameWidth = 2;
        Pen pen_Frame = new Pen(Color.Gray, frameWidth);
        Brush brush_string = Brushes.DarkBlue;
        private void PaintWorkRegion(PaintEventArgs e)
        {
            #region 画EQ曲线区域，顺序： 上下左右
            Point p1 = new Point(xAxis_Shift, frameWidth / 2);
            Point p2 = new Point(this.EQ_CurvePanel.Width - frameWidth / 2, frameWidth / 2);
            Point p3 = new Point(xAxis_Shift, this.EQ_CurvePanel.Height - yAxis_Shift);
            Point p4 = new Point(this.EQ_CurvePanel.Width - frameWidth / 2, this.EQ_CurvePanel.Height - yAxis_Shift);
            e.Graphics.DrawLine(pen_Frame, p1, p2);
            e.Graphics.DrawLine(pen_Frame, p3, p4);
            e.Graphics.DrawLine(pen_Frame, p1, p3);
            e.Graphics.DrawLine(pen_Frame, p2, p4);
            #endregion 画EQ曲线区域，顺序： 上下左右

            #region Paint Freq Grid and Label
            // 1. Calcuate Freq points (X Axis), calc how many repeat cycles first and then calc first and last cycles remiand count.
            double totalLogLen = Math.Log10(MaxFreq) - Math.Log10(MinFreq);
            double xAxisLogUnitLen = (double)(this.EQ_CurvePanel.Width - xAxis_Shift) / totalLogLen;
            int xAxisPointCount = (int)Math.Ceiling(totalLogLen * 9);
            xAxisPoint_1.Clear();
            xAxisPoint_2.Clear();
            largGridIx_Freq.Clear();
            xAxisString.Clear();
            xAxisStringLoca.Clear();
            //List<Point> xAxisPoint_1 = new List<Point>{ };
            //List<Point> xAxisPoint_2 = new List<Point>{ };
            //List<int> largGridIx_Freq = new List<int> { };
            int tempFreq = MinFreq;
            int step,tempX;
            
            //Add first Freq
            xAxisString.Add(MinFreq.ToString());
            SizeF tempSize = e.Graphics.MeasureString(MinFreq.ToString(), this.Font);
            xAxisStringLoca.Add(new Point( xAxis_Shift - (int)tempSize.Width / 2, this.EQ_CurvePanel.Height - yAxis_Shift + 5));
            while (tempFreq < MaxFreq)
            {
                step = tempFreq < 10 ? 1 : (tempFreq < 100 ? 10 : (tempFreq < 1000 ? 100 : (tempFreq < 10000 ? 1000 : 10000)));

                while (((tempFreq / step) < 10) && tempFreq <= MaxFreq)
                {
                    tempX = xAxis_Shift + (int)((Math.Log10(tempFreq) - Math.Log10(MinFreq)) * xAxisLogUnitLen);
                    xAxisPoint_1.Add(new Point(tempX, frameWidth));
                    xAxisPoint_2.Add(new Point(tempX, this.EQ_CurvePanel.Height - yAxis_Shift));

                    if (tempFreq / step == 1)
                    {
                        largGridIx_Freq.Add(xAxisPoint_1.Count - 1);
                        xAxisString.Add(tempFreq.ToString());
                        tempSize = e.Graphics.MeasureString(tempFreq.ToString(), this.Font);
                        xAxisStringLoca.Add(new Point(tempX - (int)tempSize.Width / 2, this.EQ_CurvePanel.Height - yAxis_Shift + 5));
                    }

                    tempFreq += step;                    
                }

                if (tempFreq >= MaxFreq)
                    break;
            }

            // 2.draw small grid, skiped first one which is overlapped with frame
            for (int ix = 1; ix < xAxisPoint_1.Count; ix++)
            {
                e.Graphics.DrawLine(pen_smallGrid, xAxisPoint_1[ix], xAxisPoint_2[ix]);
            }

            // 3. draw large grid
            for (int ix = 0; ix < largGridIx_Freq.Count; ix++)
            {
                e.Graphics.DrawLine(pen_largeGrid, xAxisPoint_1[largGridIx_Freq[ix]], xAxisPoint_2[largGridIx_Freq[ix]]);
            }

            // 4. paint freq label
            for (int ix = 0; ix < xAxisStringLoca.Count; ix++)
            {
                e.Graphics.DrawString(xAxisString[ix], this.Font, brush_string, xAxisStringLoca[ix]);
            }
            #endregion Paint Grid

            #region Paint Magnitude and Label
            yAxisPoint_1.Clear();
            yAxisPoint_2.Clear();
            GridIx_20dBMag.Clear();
            yAxisString.Clear();
            yAxisStringLoca.Clear();
            double magRange = MaxMag - MinMag;
            double yAxisLogUnitLen = (this.EQ_CurvePanel.Height - yAxis_Shift) / magRange;
            int tempMag = MaxMag;
            int magStep_dB = 5;
            int tempStep_YLen;
            if (tempMag % magStep_dB != 0)
            {
                tempStep_YLen = (int)((tempMag % magStep_dB) * yAxisLogUnitLen);
                yAxisPoint_1.Add(new Point(xAxis_Shift, tempStep_YLen));
                yAxisPoint_2.Add(new Point(this.Width - frameWidth, tempStep_YLen));
                tempMag = tempMag - (tempMag % magStep_dB);
            }
            
            while (tempMag > MinMag)
            {
                tempStep_YLen = (int)((MaxMag - tempMag) * yAxisLogUnitLen);
                yAxisPoint_1.Add(new Point(xAxis_Shift, tempStep_YLen));
                yAxisPoint_2.Add(new Point(this.Width - frameWidth, tempStep_YLen));

                if (tempMag % 20 == 0 && tempMag < MaxMag)
                {
                    GridIx_20dBMag.Add(yAxisPoint_1.Count - 1);
                    yAxisString.Add(tempMag.ToString());
                    tempSize = e.Graphics.MeasureString(tempMag.ToString(), this.Font);
                    yAxisStringLoca.Add(new Point(xAxis_Shift - (int)tempSize.Width - 5, tempStep_YLen - (int)tempSize.Height / 2));
                }

                tempMag -= magStep_dB;
            }

            // Add Min Mag
            yAxisString.Add(MinMag.ToString());
            tempSize = e.Graphics.MeasureString(MinMag.ToString(), this.Font);
            yAxisStringLoca.Add(new Point(xAxis_Shift - (int)tempSize.Width - 5, 
                this.EQ_CurvePanel.Height - yAxis_Shift - (int)tempSize.Height / 2));

            // paint 5dB mark
            for (int ix = 0; ix < yAxisPoint_1.Count; ix++)
            {
                e.Graphics.DrawLine(pen_smallGrid, yAxisPoint_1[ix].X, yAxisPoint_1[ix].Y,
                    yAxisPoint_1[ix].X + 5, yAxisPoint_1[ix].Y);
                e.Graphics.DrawLine(pen_smallGrid, yAxisPoint_2[ix].X - 5, yAxisPoint_2[ix].Y,
                    yAxisPoint_2[ix].X, yAxisPoint_2[ix].Y);
            }

            for (int ix = 0; ix < GridIx_20dBMag.Count; ix++)
            {
                e.Graphics.DrawLine(pen_smallGrid, yAxisPoint_1[GridIx_20dBMag[ix]], yAxisPoint_2[GridIx_20dBMag[ix]]);
            }

            // Paint Magnitude label
            for (int ix = 0; ix < yAxisStringLoca.Count; ix++)
            {
                e.Graphics.DrawString(yAxisString[ix], this.Font, brush_string, yAxisStringLoca[ix]); 
            }
            #endregion Paint Magnitude
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

        #endregion Methods

        private void EQ_CurvePanel_Paint(object sender, PaintEventArgs e)
        {
            // Transfer (0,0) to X Axis and Y Axis cross point
            //e.Graphics.TranslateTransform(50,10);
            //e.Graphics.RotateTransform(

            PaintWorkRegion(e);
        }

        private void numUP_MinFreq_ValueChanged(object sender, EventArgs e)
        {
            this.MinFreq = (int)numUP_MinFreq.Value;
            this.EQ_CurvePanel.Refresh();
        }

        private void numUP_MaxFreq_ValueChanged(object sender, EventArgs e)
        {
            this.MaxFreq = (int)numUP_MaxFreq.Value;
            this.EQ_CurvePanel.Refresh();
        }

        private void numUP_MinMagn_ValueChanged(object sender, EventArgs e)
        {
            this.MinMag = (int)numUP_MinMagn.Value;
            this.EQ_CurvePanel.Refresh();
        }

        private void numUP_MaxMagn_ValueChanged(object sender, EventArgs e)
        {
            this.MaxMag = (int)numUP_MaxMagn.Value;
            this.EQ_CurvePanel.Refresh();
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
            No = 0,
            Type = 1,
            SubType = 2,
            Freq = 3,
            Gain = 4,
            BW = 5,
            QFatcor = 6,
            View = 7,
            Bypass = 8,
            Color = 9
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
