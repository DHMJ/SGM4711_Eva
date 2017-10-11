using System;
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

        double[] a = new double[2];
        double[] b = new double[2];
        double f0;
        double fs = 48000;      //Default 48KHz
        double gain_dB;
        double gain_linear;
        double bandwidth;
        double q_factor;
        
        double w0;
        #endregion Coefficents

        public Filter()
        {
            w0 = 2 * Math.PI * f0 / fs;
            gain_linear = Math.Pow(10.0, gain_dB / 20.0);
        }

        #region Coefficents Calculation
        void UpdateCoefficents()
        {
            switch (this.filterType)
            {
                case FilterType.Peaking:
                    break;
                case FilterType.Shelving:
                    break;
                case FilterType.LowPass:
                    break;
                case FilterType.HighPass:
                    break;
            } 
        }

        #endregion Coefficents Calculation


        #region Properties
        public double[] A
        {
            set { a = value; }
            get { return a; }
        }

        public double[] B
        {
            set { b = value; }
            get { return b; }
        }

        public double FS
        {
            set { fs = value; }
            get { return fs; }
        }

        public double F0
        {
            set { f0 = value; }
            get { return f0; }
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
