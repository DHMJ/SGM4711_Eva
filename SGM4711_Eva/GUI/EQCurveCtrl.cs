﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGM4711_Eva.MDCommon.Filter;
using MD.MDCommon;
using System.IO;
using System.Runtime.Serialization;

namespace SGM4711_Eva.GUI
{
    [Serializable]
    public partial class EQCurveCtrl : UserControl, ISerializable
    {
        IRegOperation myRegOp;
        RegisterMap regMap;
        byte[] regAddr;
        public EQCurveCtrl(IRegOperation _myRegOp, int filterCount, RegisterMap _regmap, byte[] _regAddr)
        {
            InitializeComponent();
            myRegOp = _myRegOp;
            this.regMap = _regmap;
            this.regAddr = _regAddr;
            InitDVG();
            InitSetting(filterCount);
            //UpdateDrawPoints_Frame();
            //UpdateFreqPointForFR();
        }

        public void SerializableForm(SerializationInfo info, StreamingContext context)
        {
            this.filterList = (List<Filter>)info.GetValue("Filters", typeof(List<Filter>));
            this.settings = (List<FilterSetting>)info.GetValue("FilterSettings", typeof(List<FilterSetting>));
            //this.Name   =   info.GetString( "Name "); 
            //this.Size   =   (Size)info.GetValue( "Size ",   typeof(Size)); 
            //this.Location   =   (Point)info.GetValue( "Location ",   typeof(Point)); 
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FilterSettings", settings);
            info.AddValue("Filters", filterList);
            //info.AddValue( "Name ",   this.Name);
            //info.AddValue( "Size ",   this.Size);
            //info.AddValue( "Location ",   this.Location);
        } 

        public void UpdateRegMap(RegisterMap _regmap)
        {
            this.regMap = _regmap;
        }

        #region Params
        int xAxis_Shift = 30;
        int yAxis_Shift = 30;

        // Frequency and Magnitude
        int MinFreq = 20;
        int MaxFreq = 20000;
        int MinMag = -80;
        int MaxMag = 40;

        // Limitation for parameters
        double MaxGaindB = 30;
        double MinGaindB = -100;

        double MaxBW = 20000;
        double MinBW = 10;

        double MaxQFactor = 20;
        double MinQFactor = 0.05;

        bool EQView = true;

        // Frequency response calculation
        int freqCountPerUnit = 800;     // how many freqs will be calc per unit. e.g. 100 point for 100 - 1000Hz and 1000Hz- 10000Hz...

        // Log Axis steps
        double[] logAxisStep = new double[] {Math.Log10(2), Math.Log10(3) - Math.Log10(2), Math.Log10(4) - Math.Log10(3),
            Math.Log10(5) - Math.Log10(4), Math.Log10(6) - Math.Log10(5), Math.Log10(7) - Math.Log10(6),
            Math.Log10(8) - Math.Log10(7), Math.Log10(9) - Math.Log10(8), Math.Log10(10) - Math.Log10(9)};

        /* Settings: No. Type SubType Frequency Gain BandWidth QFactor View Bypass Color */
        List<Filter> filterList = new List<Filter> { };
        List<FilterSetting> settings = new List<FilterSetting> { };
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
        List<double> freqPointForFR = new List<double> { };     //freq point will be used to calc freq response
        List<Point> freqPointLocaForFR = new List<Point> { };   //all the locations for freq point has been calc for sum freq response
        Point[][] freqResponsePointsLoca;                       //stores all the point for each filter's FR.
        int defaultFRYAxisLoca = 0;

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

            #region Draw Freq Grid and Label
            // 1. Calcuate Freq points (X Axis), calc how many repeat cycles first and then calc first and last cycles remiand count.
            //double totalLogLen = Math.Log10(MaxFreq) - Math.Log10(MinFreq);
            //double xAxisLogUnitLen = (double)(this.EQ_CurvePanel.Width - xAxis_Shift) / totalLogLen;
            //int xAxisPointCount = (int)Math.Ceiling(totalLogLen * 9);
            //xAxisPoint_1.Clear();
            //xAxisPoint_2.Clear();
            //largGridIx_Freq.Clear();
            //xAxisString.Clear();
            //xAxisStringLoca.Clear();
            ////List<Point> xAxisPoint_1 = new List<Point>{ };
            ////List<Point> xAxisPoint_2 = new List<Point>{ };
            ////List<int> largGridIx_Freq = new List<int> { };
            //int tempFreq = MinFreq;
            //int step,tempX;
            
            ////Add first Freq
            //xAxisString.Add(MinFreq.ToString());
            //SizeF tempSize = e.Graphics.MeasureString(MinFreq.ToString(), this.Font);
            //xAxisStringLoca.Add(new Point( xAxis_Shift - (int)tempSize.Width / 2, this.EQ_CurvePanel.Height - yAxis_Shift + 5));
            //while (tempFreq < MaxFreq)
            //{
            //    step = tempFreq < 10 ? 1 : (tempFreq < 100 ? 10 : (tempFreq < 1000 ? 100 : (tempFreq < 10000 ? 1000 : 10000)));

            //    while (((tempFreq / step) < 10) && tempFreq <= MaxFreq)
            //    {
            //        tempX = xAxis_Shift + (int)((Math.Log10(tempFreq) - Math.Log10(MinFreq)) * xAxisLogUnitLen);
            //        xAxisPoint_1.Add(new Point(tempX, frameWidth));
            //        xAxisPoint_2.Add(new Point(tempX, this.EQ_CurvePanel.Height - yAxis_Shift));

            //        if (tempFreq / step == 1)
            //        {
            //            largGridIx_Freq.Add(xAxisPoint_1.Count - 1);
            //            xAxisString.Add(tempFreq.ToString());
            //            tempSize = e.Graphics.MeasureString(tempFreq.ToString(), this.Font);
            //            xAxisStringLoca.Add(new Point(tempX - (int)tempSize.Width / 2, this.EQ_CurvePanel.Height - yAxis_Shift + 5));
            //        }

            //        tempFreq += step;                    
            //    }

            //    if (tempFreq >= MaxFreq)
            //        break;
            //}

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

            #region Draw Magnitude and Label
            //yAxisPoint_1.Clear();
            //yAxisPoint_2.Clear();
            //GridIx_20dBMag.Clear();
            //yAxisString.Clear();
            //yAxisStringLoca.Clear();
            //double magRange = MaxMag - MinMag;
            //double yAxisLogUnitLen = (this.EQ_CurvePanel.Height - yAxis_Shift) / magRange;
            //int tempMag = MaxMag;
            //int magStep_dB = 5;
            //int tempStep_YLen;
            //if (tempMag % magStep_dB != 0)
            //{
            //    tempStep_YLen = (int)((tempMag % magStep_dB) * yAxisLogUnitLen);
            //    yAxisPoint_1.Add(new Point(xAxis_Shift, tempStep_YLen));
            //    yAxisPoint_2.Add(new Point(this.Width - frameWidth, tempStep_YLen));
            //    tempMag = tempMag - (tempMag % magStep_dB);
            //}
            
            //while (tempMag > MinMag)
            //{
            //    tempStep_YLen = (int)((MaxMag - tempMag) * yAxisLogUnitLen);
            //    yAxisPoint_1.Add(new Point(xAxis_Shift, tempStep_YLen));
            //    yAxisPoint_2.Add(new Point(this.Width - frameWidth, tempStep_YLen));

            //    if (tempMag % 20 == 0 && tempMag < MaxMag)
            //    {
            //        GridIx_20dBMag.Add(yAxisPoint_1.Count - 1);
            //        yAxisString.Add(tempMag.ToString());
            //        tempSize = e.Graphics.MeasureString(tempMag.ToString(), this.Font);
            //        yAxisStringLoca.Add(new Point(xAxis_Shift - (int)tempSize.Width - 5, tempStep_YLen - (int)tempSize.Height / 2));
            //    }

            //    tempMag -= magStep_dB;
            //}

            //// Add Min Mag
            //yAxisString.Add(MinMag.ToString());
            //tempSize = e.Graphics.MeasureString(MinMag.ToString(), this.Font);
            //yAxisStringLoca.Add(new Point(xAxis_Shift - (int)tempSize.Width - 5, 
            //    this.EQ_CurvePanel.Height - yAxis_Shift - (int)tempSize.Height / 2));

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

            #region Draw Filter FR curve
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen_FRCurve;
            for (int ix = 0; ix < filterList.Count; ix++)
            {
                // Draw each filter FR curve
                if (!settings[ix].View)
                    continue;
                else
                {
                    pen_FRCurve = new Pen(settings[ix].CurveColor, 1);
                    e.Graphics.DrawCurve(pen_FRCurve, freqResponsePointsLoca[ix]);
                    //e.Graphics.DrawPolygon(pen_FRCurve, freqResponsePointsLoca[ix]);
                }
            }

            // Draw sum FR curve
            if (EQView)
            {
                pen_FRCurve = new Pen(FilterCurveColor.EQCurveColor, 2);
                e.Graphics.DrawCurve(pen_FRCurve, freqPointLocaForFR.ToArray());
                //e.Graphics.DrawPolygon(pen_FRCurve, freqPointLocaForFR.ToArray());
            }

            // Return the smooth way to default
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            #endregion 
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
            (dgv_filterSetting.Columns[1] as DataGridViewComboBoxColumn).Items.Add(FilterType.Notch.ToString());

            // Filter SubType
            dgv_filterSetting.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_filterSetting.Columns[2].Width = 150;
            dgv_filterSetting.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[2].HeaderText = "Filter SubType";
            dgv_filterSetting.Columns[2].ReadOnly = true;
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
            dgv_filterSetting.Columns[3].ReadOnly = true;

            // Gain (dB)
            dgv_filterSetting.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_filterSetting.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[4].HeaderText = "Gain (dB)";
            dgv_filterSetting.Columns[4].ReadOnly = true;

            // BandWidth (Hz)
            dgv_filterSetting.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_filterSetting.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[5].HeaderText = "BandWidth (Hz)";
            dgv_filterSetting.Columns[5].ReadOnly = true;

            // Q Factor
            dgv_filterSetting.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgv_filterSetting.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_filterSetting.Columns[6].HeaderText = "Q Factor";
            dgv_filterSetting.Columns[6].ReadOnly = true;

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

        private void InitSetting(int count)
        {
            freqResponsePointsLoca = new Point[count][];
            for (int ix = 0; ix < count; ix++)
            {
                freqResponsePointsLoca[ix] = new Point[100];
            }

            settings.Clear();
            filterList.Clear();
            for (int ix = 0; ix < count; ix++)
            {
                settings.Add(new FilterSetting(ix, FilterCurveColor.FilterCurveColors(ix)));
                filterList.Add(new Filter(settings[ix]));
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

            UpdateDrawPoints_Frame();
            UpdateFreqPointForFR();

            // Set GUI display feature
            for (int ix = 0; ix < filterList.Count; ix++)
                UpdateFilterSetFeature(ix, FilterType.AllPass);
        }

        private void UpdateGUIFromSetting()
        {
            this.dgv_filterSetting.CellValueChanged -= dgv_filterSetting_CellValueChanged;
            this.EQ_CurvePanel.Paint -= EQ_CurvePanel_Paint;
            UpdateDrawPoints_Frame();
            UpdateFreqPointForFR();

            /* No.{0}, Filter Type, SubType, F0, Gain, Bandwidth, Q, View, Bypass */
            for (int filterNo = 0; filterNo < settings.Count; filterNo++)
            {
                FilterSetting currentSet = settings[filterNo];
                dgv_filterSetting[(int)paramIx.Type, filterNo].Value = currentSet.Type.ToString();
                dgv_filterSetting[(int)paramIx.SubType, filterNo].Value = currentSet.SubType.ToString();
                dgv_filterSetting[(int)paramIx.Freq, filterNo].Value = currentSet.Freq.ToString("F2");
                dgv_filterSetting[(int)paramIx.Gain, filterNo].Value = currentSet.Gain.ToString("F2");
                dgv_filterSetting[(int)paramIx.BW, filterNo].Value = currentSet.BandWidth.ToString("F2");
                dgv_filterSetting[(int)paramIx.QFatcor, filterNo].Value = currentSet.QFactor.ToString("F3");
                dgv_filterSetting[(int)paramIx.View, filterNo].Value = currentSet.View;
                dgv_filterSetting[(int)paramIx.Bypass, filterNo].Value = currentSet.Bypass;
                filterList[filterNo].UpdateCoefficents(freqPointForFR.ToArray());

                // Set GUI display feature
                UpdateFilterSetFeature(filterNo, currentSet.Type);

            }

            UpdateDrawPoints_FR(-1);

            this.dgv_filterSetting.CellValueChanged += dgv_filterSetting_CellValueChanged;
            this.EQ_CurvePanel.Paint += EQ_CurvePanel_Paint;
            this.EQ_CurvePanel.Refresh();
        }

        private void UpdateFilterSetFeature(int _ixFilter, FilterType _fType)
        {
            DataGridViewRow currentRow = dgv_filterSetting.Rows[_ixFilter];
            this.dgv_filterSetting.CellValueChanged -= dgv_filterSetting_CellValueChanged;
            switch (_fType)
            {
                case FilterType.AllPass:
                    // Enable/Disable other settings
                    currentRow.Cells[(int)paramIx.SubType].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.SubType].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.SubType].Style.SelectionBackColor = Color.Gray;
                    
                    currentRow.Cells[(int)paramIx.Freq].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.Freq].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.Freq].Style.SelectionBackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.Freq].Value = "NA";

                    currentRow.Cells[(int)paramIx.Gain].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.Gain].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.Gain].Style.SelectionBackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.Gain].Value = "NA";

                    currentRow.Cells[(int)paramIx.QFatcor].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.QFatcor].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.QFatcor].Style.SelectionBackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.QFatcor].Value = "NA";

                    currentRow.Cells[(int)paramIx.BW].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.BW].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.BW].Style.SelectionBackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.BW].Value = "NA";

                    this.dgv_filterSetting.CellValueChanged += dgv_filterSetting_CellValueChanged;
                    (currentRow.Cells[2] as DataGridViewComboBoxCell).Items.Clear();
                    (currentRow.Cells[2] as DataGridViewComboBoxCell).Items.Add(FilterSubType.None.ToString());
                    currentRow.Cells[2].Value = FilterSubType.None.ToString();
                    break;

                case FilterType.Peaking:
                    // Enable/Disable other settings
                    currentRow.Cells[(int)paramIx.SubType].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.SubType].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.SubType].Style.SelectionBackColor = Color.Gray;

                    currentRow.Cells[(int)paramIx.Freq].ReadOnly = false;
                    currentRow.Cells[(int)paramIx.Freq].Style.BackColor = Color.White;
                    currentRow.Cells[(int)paramIx.Freq].Style.SelectionBackColor = SystemColors.Highlight;
                    currentRow.Cells[(int)paramIx.Freq].Value = settings[_ixFilter].Freq;

                    currentRow.Cells[(int)paramIx.Gain].ReadOnly = false;
                    currentRow.Cells[(int)paramIx.Gain].Style.BackColor = Color.White;
                    currentRow.Cells[(int)paramIx.Gain].Style.SelectionBackColor = SystemColors.Highlight;
                    currentRow.Cells[(int)paramIx.Gain].Value = settings[_ixFilter].Gain;
                    
                    currentRow.Cells[(int)paramIx.QFatcor].ReadOnly = false;
                    currentRow.Cells[(int)paramIx.QFatcor].Style.BackColor = Color.White;
                    currentRow.Cells[(int)paramIx.QFatcor].Style.SelectionBackColor = SystemColors.Highlight;
                    currentRow.Cells[(int)paramIx.QFatcor].Value = settings[_ixFilter].QFactor;
                    
                    currentRow.Cells[(int)paramIx.BW].ReadOnly = false;
                    currentRow.Cells[(int)paramIx.BW].Style.BackColor = Color.White;
                    currentRow.Cells[(int)paramIx.BW].Style.SelectionBackColor = SystemColors.Highlight;
                    currentRow.Cells[(int)paramIx.BW].Value = settings[_ixFilter].BandWidth;

                    this.dgv_filterSetting.CellValueChanged += dgv_filterSetting_CellValueChanged;
                    (currentRow.Cells[2] as DataGridViewComboBoxCell).Items.Clear();
                    (currentRow.Cells[2] as DataGridViewComboBoxCell).Items.Add(FilterSubType.None.ToString());
                    currentRow.Cells[2].Value = FilterSubType.None.ToString();
                    break;

                case FilterType.HighPass:
                case FilterType.LowPass:
                    // Enable/Disable other settings
                    currentRow.Cells[(int)paramIx.SubType].ReadOnly = false;
                    currentRow.Cells[(int)paramIx.SubType].Style.BackColor = Color.White;
                    currentRow.Cells[(int)paramIx.SubType].Style.SelectionBackColor = SystemColors.Highlight;

                    currentRow.Cells[(int)paramIx.Freq].ReadOnly = false;
                    currentRow.Cells[(int)paramIx.Freq].Style.BackColor = Color.White;
                    currentRow.Cells[(int)paramIx.Freq].Style.SelectionBackColor = SystemColors.Highlight;
                    currentRow.Cells[(int)paramIx.Freq].Value = settings[_ixFilter].Freq;
                    
                    currentRow.Cells[(int)paramIx.Gain].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.Gain].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.Gain].Style.SelectionBackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.Gain].Value = "NA";
                    
                    currentRow.Cells[(int)paramIx.QFatcor].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.QFatcor].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.QFatcor].Style.SelectionBackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.QFatcor].Value = "NA";
                    
                    currentRow.Cells[(int)paramIx.BW].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.BW].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.BW].Style.SelectionBackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.BW].Value = "NA";

                    this.dgv_filterSetting.CellValueChanged += dgv_filterSetting_CellValueChanged;
                    (currentRow.Cells[2] as DataGridViewComboBoxCell).Items.Clear();
                    (currentRow.Cells[2] as DataGridViewComboBoxCell).Items.Add(FilterSubType.Butterworth.ToString());
                    currentRow.Cells[2].Value = FilterSubType.Butterworth.ToString();
                    break;

                case FilterType.Notch:
                    // Enable/Disable other settings
                    currentRow.Cells[(int)paramIx.SubType].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.SubType].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.SubType].Style.SelectionBackColor = Color.Gray;
                    
                    currentRow.Cells[(int)paramIx.Freq].ReadOnly = false;
                    currentRow.Cells[(int)paramIx.Freq].Style.BackColor = Color.White;
                    currentRow.Cells[(int)paramIx.Freq].Style.SelectionBackColor = SystemColors.Highlight;
                    currentRow.Cells[(int)paramIx.Freq].Value = settings[_ixFilter].Freq;
                    
                    currentRow.Cells[(int)paramIx.Gain].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.Gain].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.Gain].Style.SelectionBackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.Gain].Value = "NA";
                    
                    currentRow.Cells[(int)paramIx.QFatcor].ReadOnly = false;
                    currentRow.Cells[(int)paramIx.QFatcor].Style.BackColor = Color.White;
                    currentRow.Cells[(int)paramIx.QFatcor].Style.SelectionBackColor = SystemColors.Highlight;
                    currentRow.Cells[(int)paramIx.QFatcor].Value = settings[_ixFilter].QFactor;
                    
                    currentRow.Cells[(int)paramIx.BW].ReadOnly = false;
                    currentRow.Cells[(int)paramIx.BW].Style.BackColor = Color.White;
                    currentRow.Cells[(int)paramIx.BW].Style.SelectionBackColor = SystemColors.Highlight;
                    currentRow.Cells[(int)paramIx.BW].Value = settings[_ixFilter].BandWidth;

                    this.dgv_filterSetting.CellValueChanged += dgv_filterSetting_CellValueChanged;
                    (currentRow.Cells[2] as DataGridViewComboBoxCell).Items.Clear();
                    (currentRow.Cells[2] as DataGridViewComboBoxCell).Items.Add(FilterSubType.None.ToString());
                    currentRow.Cells[2].Value = FilterSubType.None.ToString();

                    break;

                case FilterType.Shelving:
                    // Enable/Disable other settings
                    currentRow.Cells[(int)paramIx.SubType].ReadOnly = false;
                    currentRow.Cells[(int)paramIx.SubType].Style.BackColor = Color.White;
                    currentRow.Cells[(int)paramIx.SubType].Style.SelectionBackColor = SystemColors.Highlight;
                    
                    currentRow.Cells[(int)paramIx.Freq].ReadOnly = false;
                    currentRow.Cells[(int)paramIx.Freq].Style.BackColor = Color.White;
                    currentRow.Cells[(int)paramIx.Freq].Style.SelectionBackColor = SystemColors.Highlight;
                    currentRow.Cells[(int)paramIx.Freq].Value = settings[_ixFilter].Freq;
                    
                    currentRow.Cells[(int)paramIx.Gain].ReadOnly = false;
                    currentRow.Cells[(int)paramIx.Gain].Style.BackColor = Color.White;
                    currentRow.Cells[(int)paramIx.Gain].Style.SelectionBackColor = SystemColors.Highlight;
                    currentRow.Cells[(int)paramIx.Gain].Value = settings[_ixFilter].Gain;
                    
                    currentRow.Cells[(int)paramIx.QFatcor].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.QFatcor].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.QFatcor].Style.SelectionBackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.QFatcor].Value = "NA";
                    
                    currentRow.Cells[(int)paramIx.BW].ReadOnly = true;
                    currentRow.Cells[(int)paramIx.BW].Style.BackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.BW].Style.SelectionBackColor = Color.Gray;
                    currentRow.Cells[(int)paramIx.BW].Value = "NA";

                    this.dgv_filterSetting.CellValueChanged += dgv_filterSetting_CellValueChanged;
                    (currentRow.Cells[2] as DataGridViewComboBoxCell).Items.Clear();
                    (currentRow.Cells[2] as DataGridViewComboBoxCell).Items.Add(FilterSubType.Low.ToString());
                    (currentRow.Cells[2] as DataGridViewComboBoxCell).Items.Add(FilterSubType.High.ToString());
                    currentRow.Cells[2].Value = FilterSubType.Low.ToString();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// This method will generate which frequency will be calcuated for FR curve.
        /// </summary>
        private void UpdateFreqPointForFR()
        {
            freqPointForFR.Clear();
            freqPointLocaForFR.Clear();

            double totalLogLen = Math.Log10(MaxFreq) - Math.Log10(MinFreq);
            double xAxisLogUnitLen = (double)(this.EQ_CurvePanel.Width - xAxis_Shift) / totalLogLen;
            double yAxisLogUnitLen = (this.EQ_CurvePanel.Height - yAxis_Shift) / double.Parse((MaxMag - MinMag).ToString());
            //int defaultFRYAxisLoca = MinMag >= 0 ? this.EQ_CurvePanel.Height - yAxis_Shift : 
            //    (MaxMag <= 0 ? frameWidth : (int)(yAxisLogUnitLen * MaxMag));

            defaultFRYAxisLoca = (int)(yAxisLogUnitLen * MaxMag);   // can be negative

            int tempFreq = MinFreq;
            double tempTargetFreq = MinFreq;
            int tempTargetFreqLoca = xAxis_Shift;
            int step;
            double tempLoopCount;
            double tempFreqIncreaseStep;

            //Add first Freq
            freqPointForFR.Add(tempFreq);
            freqPointLocaForFR.Add(new Point(xAxis_Shift, defaultFRYAxisLoca));

            while (tempFreq < MaxFreq)
            {
                step = tempFreq < 10 ? 1 : (tempFreq < 100 ? 10 : (tempFreq < 1000 ? 100 : (tempFreq < 10000 ? 1000 : 10000)));

                while (((tempFreq / step) < 10) && tempFreq <= MaxFreq)
                {
                    tempTargetFreq = tempFreq;
                    tempLoopCount = (int)(logAxisStep[(int)(tempFreq / step) - 1] * freqCountPerUnit);
                    tempFreqIncreaseStep = (double)Math.Round(step / tempLoopCount, 2);
                    while (tempTargetFreq < tempFreq + step)
                    {
                        if (tempTargetFreq > MinFreq && tempTargetFreq < MaxFreq)
                        {
                            // if 2 freq too close, then will get 2 different freq with same freq location, then will remove the last one and keep latest one.
                            tempTargetFreqLoca = xAxis_Shift + (int)((Math.Log10(tempTargetFreq) - Math.Log10(MinFreq)) * xAxisLogUnitLen);
                            if(freqPointLocaForFR.Count > 0 && tempTargetFreqLoca == freqPointLocaForFR[freqPointLocaForFR.Count - 1].X)
                            {
                                freqPointForFR.RemoveAt(freqPointForFR.Count - 1);
                                freqPointLocaForFR.RemoveAt(freqPointLocaForFR.Count - 1);
                            }

                            freqPointForFR.Add((double)Math.Round(tempTargetFreq, 2));
                            freqPointLocaForFR.Add(new Point(tempTargetFreqLoca, defaultFRYAxisLoca));
                        }
                        tempTargetFreq += tempFreqIncreaseStep;
                    }

                    if (tempFreq == MinFreq)
                    {
                        // if minFreq is not a integer times of step, then mannually set it to
                        // eg. if minFreq = 21Hz, then next time will calc/draw 30Hz, not 31Hz
                        tempFreq += step;
                        tempFreq -= tempFreq % step;
                    }
                    else
                        tempFreq += step;
                }

                if (tempFreq >= MaxFreq)
                    break;
            }

            //Add last Freq
            freqPointForFR.Add(MaxFreq);
            freqPointLocaForFR.Add(new Point(this.EQ_CurvePanel.Width, defaultFRYAxisLoca));

            // Fresh Frequency Point draw point array
            for (int ix = 0; ix < freqResponsePointsLoca.Length; ix++)
            {
                freqResponsePointsLoca[ix] = new Point[freqPointLocaForFR.Count];
                for (int ix_freqCount = 0; ix_freqCount < freqPointLocaForFR.Count; ix_freqCount++)
                {
                    freqResponsePointsLoca[ix][ix_freqCount].X = freqPointLocaForFR[ix_freqCount].X;
                    freqResponsePointsLoca[ix][ix_freqCount].Y = freqPointLocaForFR[ix_freqCount].Y;
                }
            }
        }

        /// <summary>
        /// This method will re-calculate the frame draw points
        /// </summary>
        private void UpdateDrawPoints_Frame()
        {
            #region 1. Update Frequency points
            Graphics tempGraphic = this.EQ_CurvePanel.CreateGraphics();

            double totalLogLen = Math.Log10(MaxFreq) - Math.Log10(MinFreq);
            double xAxisLogUnitLen = (double)(this.EQ_CurvePanel.Width - xAxis_Shift) / totalLogLen;
            //int xAxisPointCount = (int)Math.Ceiling(totalLogLen * 9);
            xAxisPoint_1.Clear();
            xAxisPoint_2.Clear();
            largGridIx_Freq.Clear();
            xAxisString.Clear();
            xAxisStringLoca.Clear();
            //List<Point> xAxisPoint_1 = new List<Point>{ };
            //List<Point> xAxisPoint_2 = new List<Point>{ };
            //List<int> largGridIx_Freq = new List<int> { };
            int tempFreq = MinFreq;
            int step, tempX;

            //Add first Freq
            xAxisString.Add(MinFreq.ToString());
            SizeF tempSize = tempGraphic.MeasureString(MinFreq.ToString(), this.Font);
            xAxisStringLoca.Add(new Point(xAxis_Shift - (int)tempSize.Width / 2, this.EQ_CurvePanel.Height - yAxis_Shift + 5));
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
                        tempSize = tempGraphic.MeasureString(tempFreq.ToString(), this.Font);
                        xAxisStringLoca.Add(new Point(tempX - (int)tempSize.Width / 2, this.EQ_CurvePanel.Height - yAxis_Shift + 5));
                    }

                    if (tempFreq == MinFreq)
                    {
                        // if minFreq is not a integer times of step, then mannually set it to
                        // eg. if minFreq = 21Hz, then next time will calc/draw 30Hz, not 31Hz
                        tempFreq += step;
                        tempFreq -= tempFreq % step;        
                    }
                    else
                        tempFreq += step;
                }

                if (tempFreq >= MaxFreq)
                    break;
            }
            #endregion 

            #region 2. update Magnitude points
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
                    tempSize = tempGraphic.MeasureString(tempMag.ToString(), this.Font);
                    yAxisStringLoca.Add(new Point(xAxis_Shift - (int)tempSize.Width - 5, tempStep_YLen - (int)tempSize.Height / 2));
                }

                tempMag -= magStep_dB;
            }

            // Add Min Mag
            yAxisString.Add(MinMag.ToString());
            tempSize = tempGraphic.MeasureString(MinMag.ToString(), this.Font);
            yAxisStringLoca.Add(new Point(xAxis_Shift - (int)tempSize.Width - 5,
                this.EQ_CurvePanel.Height - yAxis_Shift - (int)tempSize.Height / 2));

            #endregion 
        }

        /// <summary>
        /// This method will update all the filter's FR points, including the sum
        /// <param name="ix_changedFilter"s>this index will decide which filter's FR draw point need to be updated, if -1 will update all</param>
        /// </summary>
        private void UpdateDrawPoints_FR(int ix_changedFilter)
        {
            int ix_filter, ix_freqCount;
            int tempSum;
            Point tempPoint = new Point();
            if (ix_changedFilter == -1)
            {
                for (ix_filter = 0; ix_filter < filterList.Count; ix_filter++)
                {
                    for (ix_freqCount = 0; ix_freqCount < freqPointLocaForFR.Count; ix_freqCount++)
                    {
                        tempPoint.X = freqPointLocaForFR[ix_freqCount].X;     
                        tempPoint.Y = CalcYAxisValueFromMagn(filterList[ix_filter].FR_Mag_out[ix_freqCount]);
                        freqResponsePointsLoca[ix_filter][ix_freqCount] = tempPoint;
                    }
                }
            }
            else if (ix_changedFilter < filterList.Count)
            {
                for (ix_freqCount = 0; ix_freqCount < freqPointLocaForFR.Count; ix_freqCount++)
                {
                    tempPoint.X = freqPointLocaForFR[ix_freqCount].X;
                    tempPoint.Y = CalcYAxisValueFromMagn(filterList[ix_changedFilter].FR_Mag_out[ix_freqCount]);
                    freqResponsePointsLoca[ix_changedFilter][ix_freqCount] = tempPoint;
                } 
            }

            // Update the sum FR curve points location
            for (ix_freqCount = 0; ix_freqCount < freqPointLocaForFR.Count; ix_freqCount++)
            {
                tempSum = defaultFRYAxisLoca;
                for (ix_filter = 0; ix_filter < filterList.Count; ix_filter++)
                {
                    if(!settings[ix_filter].Bypass)
                        tempSum += (freqResponsePointsLoca[ix_filter][ix_freqCount].Y - defaultFRYAxisLoca);
                }

                tempPoint.X = freqPointLocaForFR[ix_freqCount].X;
                tempPoint.Y = tempSum;
                //tempPoint = freqPointLocaForFR[ix_freqCount];
                //if (tempSum == 0)
                //    tempPoint.Y = defaultFRYAxisLoca;
                //else
                //    tempPoint.Y = tempSum;

                freqPointLocaForFR[ix_freqCount] = tempPoint;
            }
        }

        /// <summary>
        /// This method is used to calculate the real point y value with magnitude.
        /// </summary>
        /// <param name="currentMagValue"></param>
        /// <returns></returns>
        private int CalcYAxisValueFromMagn(double currentMagValue)
        {
            int yAxisValue = 0;
            //double
            double yAxisLogUnitLen = (this.EQ_CurvePanel.Height - yAxis_Shift) / double.Parse((MaxMag - MinMag).ToString());

            yAxisValue = (int)((MaxMag - currentMagValue) * yAxisLogUnitLen);

            return yAxisValue;
        }

        #endregion Methods

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

        #region Events
        private void dgv_filterSetting_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_filterSetting.IsCurrentCellDirty)
            {
                int colIx = dgv_filterSetting.CurrentCellAddress.X;
                if(colIx < (int)paramIx.Freq | colIx > (int)paramIx.QFatcor)
                    dgv_filterSetting.CommitEdit(DataGridViewDataErrorContexts.Commit);
                //dgv_filterSetting.CurrentCellAddress.X
                //dgv_filterSetting.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        
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
            UpdateDrawPoints_Frame();
            UpdateFreqPointForFR();
            for (int ix = 0; ix < filterList.Count; ix++)
            {
                filterList[ix].UpdateCoefficents(freqPointForFR.ToArray());
            }

            UpdateDrawPoints_FR(-1);
            this.EQ_CurvePanel.Refresh();
        }

        private void numUP_MaxFreq_ValueChanged(object sender, EventArgs e)
        {
            this.MaxFreq = (int)numUP_MaxFreq.Value;
            UpdateDrawPoints_Frame();
            UpdateFreqPointForFR();
            for (int ix = 0; ix < filterList.Count; ix++)
            {
                filterList[ix].UpdateCoefficents(freqPointForFR.ToArray());
            }

            UpdateDrawPoints_FR(-1);
            this.EQ_CurvePanel.Refresh();
        }

        private void numUP_MinMagn_ValueChanged(object sender, EventArgs e)
        {
            this.MinMag = (int)numUP_MinMagn.Value;
            this.numUP_MaxMagn.Minimum = this.MinMag + 10;

            UpdateDrawPoints_Frame();
            UpdateFreqPointForFR();
            for (int ix = 0; ix < filterList.Count; ix++)
            {
                filterList[ix].UpdateCoefficents(freqPointForFR.ToArray());
            }

            UpdateDrawPoints_FR(-1);
            this.EQ_CurvePanel.Refresh();
        }

        private void numUP_MaxMagn_ValueChanged(object sender, EventArgs e)
        {
            this.MaxMag = (int)numUP_MaxMagn.Value;
            this.numUP_MinMagn.Maximum = this.MaxMag - 10;

            UpdateDrawPoints_Frame();
            UpdateFreqPointForFR();
            for (int ix = 0; ix < filterList.Count; ix++)
            {
                filterList[ix].UpdateCoefficents(freqPointForFR.ToArray());
            }

            UpdateDrawPoints_FR(-1);
            this.EQ_CurvePanel.Refresh();
        }

        private void dgv_filterSetting_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double tempData;
            bool parseRet = false;
            if (dgv_filterSetting.Rows.Count == 0)
                return;

            DataGridViewRow currentRow = dgv_filterSetting.Rows[e.RowIndex];

            switch (e.ColumnIndex)
            {
                case (int)paramIx.No:
                    break;

                case (int)paramIx.Type:
                    settings[e.RowIndex].Type = (FilterType)Enum.Parse(typeof(FilterType), currentRow.Cells[e.ColumnIndex].Value.ToString());
                    UpdateFilterSetFeature(e.RowIndex, settings[e.RowIndex].Type);
                    break;

                case (int)paramIx.SubType:
                    settings[e.RowIndex].SubType = (FilterSubType)Enum.Parse(typeof(FilterSubType), currentRow.Cells[e.ColumnIndex].Value.ToString());
                    break;

                case (int)paramIx.Freq:
                    parseRet = double.TryParse(currentRow.Cells[e.ColumnIndex].Value.ToString(), out tempData);
                    if (parseRet && (tempData <= MaxFreq) && (tempData >= MinFreq))
                    {
                        settings[e.RowIndex].Freq = tempData;
                        //Update Q factor
                        if ((settings[e.RowIndex].Type == FilterType.Peaking) || (settings[e.RowIndex].Type == FilterType.Notch))
                        {
                            currentRow.Cells[(int)paramIx.QFatcor].Value =
                                settings[e.RowIndex].Freq / settings[e.RowIndex].BandWidth;
                        }
                    }
                    else 
                        MessageBox.Show(String.Format("Wrong Frequency Input in Row[{0}]", e.RowIndex));
                    break;

                case (int)paramIx.Gain:
                    parseRet = double.TryParse(currentRow.Cells[e.ColumnIndex].Value.ToString(), out tempData);
                    if (parseRet && (tempData <= MaxGaindB) && (tempData >= MinGaindB))
                    {
                        settings[e.RowIndex].Gain = tempData;
                    }
                    else
                        MessageBox.Show(String.Format("Wrong Gain Input in Row[{0}]", e.RowIndex));

                    break;

                case (int)paramIx.BW:
                    parseRet = double.TryParse(currentRow.Cells[e.ColumnIndex].Value.ToString(), out tempData);
                    if (parseRet && (tempData <= MaxBW) && (tempData >= MinBW))
                    {
                        settings[e.RowIndex].BandWidth = tempData;
                        //Update Q factor
                        if ((settings[e.RowIndex].Type == FilterType.Peaking) || (settings[e.RowIndex].Type == FilterType.Notch))
                        {
                            currentRow.Cells[(int)paramIx.QFatcor].Value = 
                                settings[e.RowIndex].Freq / settings[e.RowIndex].BandWidth;
                        }
                    }
                    else
                        MessageBox.Show(String.Format("Wrong Band Width Input in Row[{0}]", e.RowIndex));

                    break;

                case (int)paramIx.QFatcor:
                    parseRet = double.TryParse(currentRow.Cells[e.ColumnIndex].Value.ToString(), out tempData);
                    if (parseRet && (tempData <= MaxQFactor) && (tempData >= MinQFactor))
                    {
                        settings[e.RowIndex].QFactor = tempData;
                        //Update BW factor
                        if ((settings[e.RowIndex].Type == FilterType.Peaking) || (settings[e.RowIndex].Type == FilterType.Notch))
                        {
                            currentRow.Cells[(int)paramIx.BW].Value =
                                settings[e.RowIndex].Freq / settings[e.RowIndex].QFactor;
                        }

                    }
                    else
                        MessageBox.Show(String.Format("Wrong Q Factor Input in Row[{0}]", e.RowIndex));

                    break;

                case (int)paramIx.View:
                    settings[e.RowIndex].View = (bool)currentRow.Cells[e.ColumnIndex].Value;
                    break;

                case (int)paramIx.Bypass:
                    settings[e.RowIndex].Bypass = (bool)currentRow.Cells[e.ColumnIndex].Value;
                    break;

                case (int)paramIx.Color:
                    break;

                default:
                    break;
            }
            filterList[e.RowIndex].UpdateCoefficents(freqPointForFR.ToArray());
            UpdateDrawPoints_FR(e.RowIndex);

            this.EQ_CurvePanel.Refresh();
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

        /// <summary>
        /// This event will be used to verify if inputs in correct formate. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_filterSetting_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            double tempData;
            bool parseRet = false;
            DataGridViewRow tempRow = dgv_filterSetting.Rows[e.RowIndex];
            if (e.ColumnIndex <= (int)paramIx.Freq || e.ColumnIndex >= (int)paramIx.QFatcor)
                return;

            if (e.FormattedValue.ToString() == "NA")
                return;

            //parseRet = double.TryParse(tempRow.Cells[e.ColumnIndex].FormattedValue.ToString(), out tempData);
            FilterSetting currentSet = settings[e.RowIndex];
            FilterSetting tempSet = new FilterSetting(currentSet.Type, currentSet.SubType, currentSet.Freq, currentSet.Gain,
                currentSet.BandWidth,currentSet.QFactor, Color.White);

            parseRet = double.TryParse(e.FormattedValue.ToString(), out tempData);
            if (!parseRet)
            {
                e.Cancel = true;
                return;
            }
            
            switch (e.ColumnIndex)
            {
                case (int)paramIx.Freq:
                    if (parseRet && (tempData <= MaxFreq) && (tempData >= MinFreq))
                    {
                        tempSet.Freq = tempData;
                        if (filterList[e.RowIndex].ValidatingCoefficents(tempSet))
                            e.Cancel = false;
                        else
                        {
                            MessageBox.Show("All coefficents of EQ is 3.23 format, overflow happened!");
                            e.Cancel = true;
                        }
                    }
                    else
                        e.Cancel = true;

                    break;

                case (int)paramIx.Gain:
                    if (parseRet && (tempData <= MaxGaindB) && (tempData >= MinGaindB))
                    {
                        tempSet.Gain = tempData;
                        if (filterList[e.RowIndex].ValidatingCoefficents(tempSet))
                            e.Cancel = false;
                        else
                        {
                            MessageBox.Show("All coefficents of EQ is 3.23 format, overflow happened!");
                            e.Cancel = true;
                        }
                    }
                    else
                        e.Cancel = true;

                    break;

                case (int)paramIx.BW:
                    if (parseRet && (tempData <= MaxBW) && (tempData >= MinBW))
                    {
                        tempSet.BandWidth = tempData;
                        if (filterList[e.RowIndex].ValidatingCoefficents(tempSet))
                            e.Cancel = false;
                        else
                        {
                            MessageBox.Show("All coefficents of EQ is 3.23 format, overflow happened!");
                            e.Cancel = true;
                        }
                    }
                    else
                        e.Cancel = true;

                    break;

                case (int)paramIx.QFatcor:
                    if (parseRet && (tempData <= MaxQFactor) && (tempData >= MinQFactor))
                    {
                        tempSet.QFactor = tempData;
                        if (filterList[e.RowIndex].ValidatingCoefficents(tempSet))
                            e.Cancel = false;
                        else
                        {
                            MessageBox.Show("All coefficents of EQ is 3.23 format, overflow happened!");
                            e.Cancel = true;
                        }
                    }
                    else
                        e.Cancel = true;

                    break;

                default:
                    break;

            }
        }

        private void chb_EQCurveView_CheckedChanged(object sender, EventArgs e)
        {
            EQView = this.chb_EQCurveView.Checked;
            this.EQ_CurvePanel.Refresh();
        }
        
        private void btn_ImportEQ_Click(object sender, EventArgs e)
        {
            OpenFileDialog importFile = new OpenFileDialog();
            importFile.Title = "Import EQ setting and update to GUI...";
            importFile.Filter = "MDEQ(.mdeq)|*.mdeq|All File(*.*)|*.*";
            //importFile.RestoreDirectory = true;
            if (importFile.ShowDialog() == DialogResult.OK)
            {
                string filename = importFile.FileName;

                StreamReader sr = new StreamReader(filename);
                int successCount = 0;
                int lineNum = 1;
                FilterSetting currentSet;
                Filter currentFilter;
                //string comment = sr.ReadLine();
                string registerstate = sr.ReadLine();
                while (registerstate != null)
                {
                    if (registerstate.StartsWith("/*") || registerstate.Trim() == "")
                    {
                        registerstate = sr.ReadLine(); lineNum++;
                        continue;
                    }
                    try
                    {
                        string[] tempStr = registerstate.TrimStart(' ').TrimEnd(' ').Split(',');  //Trim blank space
                        if (tempStr.Length != 10)
                            throw new Exception(String.Format("Wrong data in line {0}!!", lineNum));
                        
                        /* No.{0}, Filter Type, SubType, FS, F0, Gain, Bandwidth, Q, View, Bypass */                            
                        currentSet = settings[successCount];
                        currentFilter = filterList[successCount];
                        currentSet.Type = (FilterType)Enum.Parse(typeof(FilterType), tempStr[1]);
                        //UpdateFilterSetFeature(successCount, currentSet.Type);
                        currentSet.SubType = (FilterSubType)Enum.Parse(typeof(FilterSubType), tempStr[2]);
                        currentSet.FS = double.Parse(tempStr[3]);
                        currentSet.Freq = double.Parse(tempStr[4]);
                        currentSet.Gain = double.Parse(tempStr[5]);
                        currentSet.BandWidth = double.Parse(tempStr[6]);
                        currentSet.QFactor= double.Parse(tempStr[7]);
                        currentSet.View = bool.Parse(tempStr[8]);
                        currentSet.Bypass = bool.Parse(tempStr[9]);
                                                
                        // count successed num after got everything
                        successCount++;
                    }
                    catch(Exception ex) { MessageBox.Show(ex.ToString()); }
                    finally { registerstate = sr.ReadLine(); lineNum++; }
                }
                UpdateGUIFromSetting();
                sr.Close();

                MessageBox.Show(String.Format("{0} filters have been imported!", successCount));
            }
        }

        private void btn_ExportEQ_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportFile = new SaveFileDialog();
            exportFile.Title = "Export all the eq setting to local file...";
            exportFile.Filter = "MDEQ(.mdeq)|*.mdeq|All File(*.*)|*.*";
            //exportFile.RestoreDirectory = true;
            if (exportFile.ShowDialog() == DialogResult.OK)
            {
                string filename = exportFile.FileName;

                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine("/* SGM4711 EQ Settings */");

                FilterSetting currentSet;
                Filter currentFilter;
                for (int ix_filter = 0; ix_filter < settings.Count; ix_filter++)
                {
                    currentSet = settings[ix_filter];
                    currentFilter = filterList[ix_filter];
                    sw.WriteLine(String.Format("/* No.{0}, Filter Type, SubType, FS, F0, Gain, Bandwidth, Q, View, Bypass */", ix_filter));
                    sw.Write(String.Format("Filter {0},", ix_filter));
                    sw.Write(String.Format("{0},", currentSet.Type.ToString()));
                    sw.Write(String.Format("{0},", currentSet.SubType.ToString()));
                    sw.Write(String.Format("{0},", currentSet.FS.ToString()));
                    sw.Write(String.Format("{0},", currentSet.Freq.ToString()));
                    sw.Write(String.Format("{0},", currentSet.Gain.ToString()));
                    sw.Write(String.Format("{0},", currentSet.BandWidth.ToString()));
                    sw.Write(String.Format("{0},", currentSet.QFactor.ToString()));
                    sw.Write(String.Format("{0},", currentSet.View.ToString()));
                    sw.Write(String.Format("{0}", currentSet.Bypass.ToString()));
                    sw.WriteLine();

                    sw.WriteLine("/* Register Value in hex: b0, b1, b2, a1, a2 */");
                    sw.WriteLine(string.Format("/*{0} {1} {2} {3} {4} */", currentFilter.RegValue_B[0].ToString("X4"), currentFilter.RegValue_B[1].ToString("X4"),
                        currentFilter.RegValue_B[2].ToString("X4"), currentFilter.RegValue_A[0].ToString("X4"), currentFilter.RegValue_A[1].ToString("X4")));
                }
                sw.Close();
            }
        }
        
        private void btn_Download_EQParam_Click(object sender, EventArgs e)
        {
            if (regMap == null)
            {
                MessageBox.Show("No Register Map");
                return;
            }

            //// Power down chip if the chip is on
            //bool ifPoweredOn = false;
            //if (regMap[0x05]["ALL_CH_PD"].BFValue == 0)
            //    ifPoweredOn = true;

            //if (ifPoweredOn)
            //{
            //    regMap[0x05]["ALL_CH_PD"].BFValue = 0x1;
            //    myRegOp.RegWrite(0x05);
            //}

            Register currentReg;
            for (int ix = 0; ix < regAddr.Length; ix++)
            {
                currentReg = regMap[regAddr[ix]];
                if (settings[ix].Bypass)
                {
                    currentReg["b0[25:0]"].BFValue = 0x800000;
                    currentReg["b1[25:0]"].BFValue = 0;
                    currentReg["b2[25:0]"].BFValue = 0;
                    currentReg["a1[25:0]"].BFValue = 0;
                    currentReg["a2[25:0]"].BFValue = 0;
                }
                else
                {
                    currentReg["b0[25:0]"].BFValue = filterList[ix].RegValue_B[0];
                    currentReg["b1[25:0]"].BFValue = filterList[ix].RegValue_B[1];
                    currentReg["b2[25:0]"].BFValue = filterList[ix].RegValue_B[2];
                    currentReg["a1[25:0]"].BFValue = filterList[ix].RegValue_A[0];
                    currentReg["a2[25:0]"].BFValue = filterList[ix].RegValue_A[1];
                }
                // Only the first write needs time log
                //if (ifPoweredOn)
                //    myRegOp.RegWrite(currentReg, false);
                //else if(ix == 0)
                if(ix == 0)
                    myRegOp.RegWrite(currentReg, true, true, false);
                else
                    myRegOp.RegWrite(currentReg, false, false, false);
            }

            myRegOp.PowerOn();
            //if (ifPoweredOn)
            //{
            //    regMap[0x05]["ALL_CH_PD"].BFValue = 0x0;
            //    myRegOp.RegWrite(0x05, false);
            //}

            myRegOp.UpdateRegSettingSource();
        }

        private void pnl_EQCurveSetting_SizeChanged(object sender, EventArgs e)
        {
            UpdateDrawPoints_Frame();
        }
        #endregion 

    }
}
