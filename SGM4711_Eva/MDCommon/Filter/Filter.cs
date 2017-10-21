﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SGM4711_Eva.MDCommon.Filter
{
    public class Filter
    {
        #region Coefficents
        FilterType filterType = FilterType.Peaking;

        double[] p = new double[3];
        double[] d = new double[2];
        int[] reg_b = new int[3];
        int[] reg_a = new int[2];
        double fc;
        double fs = 48000;      //Default 48KHz
        double gain_dB;
        double gain_linear;
        double bw;
        double q_factor;
        double k;
        double alpha;
        double beta;
        
        double w0;
        #endregion Coefficents

        public Filter()
        {
            w0 = 2 * Math.PI * fc / fs;
            gain_linear = Math.Pow(10.0, gain_dB / 20.0);
        }

        #region Coefficents Calculation
        void UpdateCoefficents()
        {
            switch (this.filterType)
            {
                case FilterType.Peaking:
                    CoeffCalc_Peaking();
                    break;
                case FilterType.Shelving:
                    break;
                case FilterType.LowPass:
                    break;
                case FilterType.HighPass:
                    break;
            } 
        }

        /// <summary>
        /// H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
        /// fs as the input signal sampling frequency, 
        /// fc as the required peak filter center frequency, 
        /// BW as the bandwidth, 
        /// G (dB) as the gain, 
        /// use the following steps for coefficient calculation:
        /// </summary>
        void CoeffCalc_Peaking()
        {
            /*******************************************
            * 1. Transfer the gain in decibels (dB) to decimal domain.
            ********************************************/
            k = Math.Pow(10, gain_dB / 20.0);

            /*******************************************
             * 2. Calculate the double precision coefficients
             * 
             * alpha = (1-sin(BW/fs * 2pi))/cos(BW/fs * 2pi)
             * beta = cos(fc/fs * 2pi)
             * p0 = ((1+k) + (1-k)*alpha)/2
             * p1 = -(1+alpha)*beta
             * p2 = ((1-k) + (1+k)*alpha)/2
             * d1 = (1 + alpha) * beta
             * d2 = - alpha
            ********************************************/
            alpha = (1 - Math.Sin(bw * 2 * Math.PI / fs)) / Math.Cos(bw * 2 * Math.PI / fs);
            beta = Math.Cos(fc * 2 * Math.PI / fs);
            p[0] = ((1 + k) + (1 - k) * alpha) / 2;
            p[1] = -(1 + alpha) * beta;
            p[2] = ((1 - k) + (1 + k) * alpha) / 2;
            d[1] = (1 + alpha) * beta;
            d[2] = -alpha;

            /*******************************************
             * 3. Transfer the double precision coefficients 
             * to integer values represented by registers.
             * 
             * b0 = round(p0 × 2^23)
             * b1 = round(p1 × 2^23)
             * b2 = round(p2 × 2^23)
             * a1 = round(d1 × 2^23)
             * a2 = round(d2 × 2^23)
            ********************************************/
            reg_b[0] = (int)Math.Round(p[0] * Math.Pow(2, 23));
            reg_b[1] = (int)Math.Round(p[1] * Math.Pow(2, 23));
            reg_b[2] = (int)Math.Round(p[2] * Math.Pow(2, 23));
            reg_a[0] = (int)Math.Round(d[1] * Math.Pow(2, 23));
            reg_a[1] = (int)Math.Round(d[2] * Math.Pow(2, 23));

            /*******************************************
             * 4. Transfer the decimal integer values 
             * to 26-bit, twos complement hex values.
            ********************************************/
        }
        #endregion Coefficents Calculation


        #region Properties
        public double[] A
        {
            set { p = value; }
            get { return p; }
        }

        public double[] B
        {
            set { d = value; }
            get { return d; }
        }

        public double FS
        {
            set { fs = value; }
            get { return fs; }
        }

        public double F0
        {
            set { fc = value; }
            get { return fc; }
        }

        public double Gain_dB
        {
            set 
            {
                gain_dB = value;
                gain_linear = Math.Pow(10.0, gain_dB / 20.0);
            }
            get { return gain_dB; }
        }

        public double Q_Factor
        {
            set
            {
                q_factor = value;                
            }
            get { return q_factor; }
        }
        
        #endregion Properties


    }

    public enum FilterType
    {
        AllPass = 0,
        Peaking = 1,
        LowPass = 2,
        HighPass = 3,
        Shelving = 4,        
    }

    public enum FilterSubType
    {
        None = 0,

        // General Low and High pass filter
        General = 1,
        Butterworth = 2,
        Bessel = 3,
        
        // Shelving filter
        Low = 10,
        High =11
    }

    public enum FilterSubType_LoHiPass
    {
        General = 1,
        Butterworth = 2,
        Bessel = 3
    }

    public enum FilterSubType_Shelving
    {
        Low = 10,
        High = 11
    }

    public class FilterSetting
    {
        public FilterSetting(int _ix, Color frCurveColor)
        {
            this.ix = _ix;
            this.curveColor = frCurveColor;
        }

        public FilterSetting(FilterType _type, FilterSubType _subType, double _freq, double _gain,
            double _bw, double _qFactor, Color _color)
        {
            this.type = _type;
            this.subType = _subType;
            this.freq = _freq;
            this.gain = _gain;
            this.bw = _bw;
            this.qFactor = _qFactor;
            this.curveColor = _color;
        }

        int ix = 0;
        public int No
        {
            get { return this.ix; }
            set { this.ix = value; }
        }

        FilterType type = FilterType.AllPass;
        public FilterType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        FilterSubType subType = FilterSubType.None;
        public FilterSubType SubType
        {
            get { return this.subType; }
            set { this.subType = value; }
        }

        double freq = 1;
        public double Freq
        {
            get { return this.freq; }
            set { this.freq = value; }
        }

        double gain = 0;
        public double Gain
        {
            get { return this.gain; }
            set { this.gain = value; }
        }

        double bw = 100;
        public double BandWidth
        {
            get { return this.bw; }
            set { this.bw = value; }
        }

        double qFactor = 1.414;
        public double QFactor
        {
            get { return this.qFactor; }
            set { this.qFactor = value; }
        }

        bool view = false;
        public bool View
        {
            get { return this.view; }
            set { this.view = value; }
        }

        bool bypass = false;
        public bool Bypass
        {
            get { return this.bypass; }
            set { this.bypass = value; }
        }

        Color curveColor = Color.Red;
        public Color CurveColor
        {
            get { return this.curveColor; }
            set { this.curveColor = value; }
        }

        //public string[] FilterTypeCollections
        //{
        //    get 
        //    {
        //        string[] temp = new string[];
        //    }
        //}

    }
}
