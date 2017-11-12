using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SGM4711_Eva.MDCommon.Filter
{
    [Serializable]
    public class Filter
    {
        #region Coefficents
        //FilterType filterType = FilterType.Peaking;
        FilterSetting myFilterSet;
        List<double> fr_Mag_out = new List<double> { };
        List<double> fr_Phase_out = new List<double> { };

        double[] p = new double[3]; // coefficent a, num
        double[] d = new double[3]; // coefficent b, den
        uint[] reg_b = new uint[3];
        uint[] reg_a = new uint[2];
        
        //double fc;
        //double fs = 48000;      //Default 48KHz
        //double gain_dB;
        //double gain_linear;
        //double bw;
        //double q_factor;
        double k;
        double alpha;
        double wc;
        double beta;
        
        //double w0;
        #endregion Coefficents

        public Filter()
        {
            //w0 = 2 * Math.PI * fc / fs;
            //gain_linear = Math.Pow(10.0, gain_dB / 20.0);
        }

        public Filter(FilterSetting _set)
        {
            //w0 = 2 * Math.PI * fc / fs;
            //gain_linear = Math.Pow(10.0, gain_dB / 20.0);
            this.myFilterSet = _set;
        }

        #region Coefficents Calculation
        public void UpdateCoefficents(double[] _freqs)
        {
            switch (myFilterSet.Type)
            {
                case FilterType.AllPass:
                    CoeffCalc_AllPass();
                    fr_Mag_out.Clear();
                    fr_Mag_out.AddRange(FrequenctResponse(_freqs, 1));
                    break;

                case FilterType.Peaking:
                    CoeffCalc_Peaking();
                    fr_Mag_out.Clear();
                    fr_Mag_out.AddRange(FrequenctResponse(_freqs, 2));
                    break;

                case FilterType.Shelving:
                    CoeffCalc_Shelving((FilterSubType_Shelving)Enum.Parse(typeof(FilterSubType_Shelving), myFilterSet.SubType.ToString()));
                    fr_Mag_out.Clear();
                    fr_Mag_out.AddRange(FrequenctResponse(_freqs, 2));
                    break;

                case FilterType.LowPass:
                    CoeffCalc_LowPass((FilterSubType_LoHiPass)Enum.Parse(typeof(FilterSubType_LoHiPass), myFilterSet.SubType.ToString()));
                    fr_Mag_out.Clear();
                    fr_Mag_out.AddRange(FrequenctResponse(_freqs, 2));

                    break;
                case FilterType.HighPass:
                    CoeffCalc_HighPass((FilterSubType_LoHiPass)Enum.Parse(typeof(FilterSubType_LoHiPass), myFilterSet.SubType.ToString()));
                    fr_Mag_out.Clear();
                    fr_Mag_out.AddRange(FrequenctResponse(_freqs, 2));

                    break;

                case FilterType.Notch:
                    CoeffCalc_Notch();
                    fr_Mag_out.Clear();
                    fr_Mag_out.AddRange(FrequenctResponse(_freqs, 2));
                    
                    break;
            } 
        }

        /// <summary>
        /// H(Z) = (0 + 1 * Z-1 + 0 * Z-2)/(1 - 0 * Z-1 - 0 * Z-2)
        /// When all pass, H(Z) = Z-1
        /// </summary>
        void CoeffCalc_AllPass()
        {
            /*******************************************
            * 1. Transfer the gain in decibels (dB) to decimal domain.
            ********************************************/

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
            p[0] = 0;
            p[1] = 1;
            p[2] = 0;
            d[1] = 0;
            d[2] = 0;

            /*******************************************
             * 3. Transfer the double precision coefficients 
             * to integer values represented by registers.
             * 
             * b0 = round(p0 × 2^23)
             * b1 = round(p1 × 2^23)
             * b2 = round(p2 × 2^23)
             * a0 = round(d1 × 2^23)
             * a1 = round(d2 × 2^23)
            ********************************************/
            reg_b[0] = (uint)Math.Round(p[0] * Math.Pow(2, 23));
            reg_b[1] = (uint)Math.Round(p[1] * Math.Pow(2, 23));
            reg_b[2] = (uint)Math.Round(p[2] * Math.Pow(2, 23));
            reg_a[0] = (uint)Math.Round(d[1] * Math.Pow(2, 23));
            reg_a[1] = (uint)Math.Round(d[2] * Math.Pow(2, 23));

            /*******************************************
             * 4. Transfer the decimal integer values 
             * to 26-bit, twos complement hex values.
            ********************************************/

            /*******************************************
             * 5. Change the p and d to be used for FR calc
             * H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
             *******************************************/
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
            k = Math.Pow(10, myFilterSet.Gain / 20.0);

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
            alpha = (1 - Math.Sin(myFilterSet.BandWidth * 2 * Math.PI / myFilterSet.FS)) / Math.Cos(myFilterSet.BandWidth * 2 * Math.PI / myFilterSet.FS);
            beta = Math.Cos(myFilterSet.Freq * 2 * Math.PI / myFilterSet.FS);
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
             * a0 = round(d1 × 2^23)
             * a1 = round(d2 × 2^23)
            ********************************************/
            reg_b[0] = (uint)Math.Round(p[0] * Math.Pow(2, 23));
            reg_b[1] = (uint)Math.Round(p[1] * Math.Pow(2, 23));
            reg_b[2] = (uint)Math.Round(p[2] * Math.Pow(2, 23));
            reg_a[0] = (uint)Math.Round(d[1] * Math.Pow(2, 23));
            reg_a[1] = (uint)Math.Round(d[2] * Math.Pow(2, 23));

            /*******************************************
             * 4. Transfer the decimal integer values 
             * to 26-bit, twos complement hex values.
            ********************************************/

            /*******************************************
             * 5. Change the p and d to be used for FR calc
             * H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
             *******************************************/
            d[1] = -d[1];
            d[2] = -d[2];
        }

        /// <summary>
        /// H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
        /// fs as the input signal sampling frequency, 
        /// fc as the required peak filter center frequency, 
        /// G (dB) as the gain, 
        /// use the following steps for coefficient calculation:
        /// <param name="hign_low">this parameter decide high pass or low pass</param>
        /// </summary>
        void CoeffCalc_Shelving(FilterSubType_Shelving low_high)
        {
            #region Comment out old 1st order shelving
            //#region Low pass shelving
            //if (low_high == FilterSubType_Shelving.Low)
            //{
            //    /*******************************************
            //    * 1. Transfer the gain in decibels (dB) to decimal domain.
            //    ********************************************/
            //    k = Math.Pow(10, myFilterSet.Gain / 20.0);

            //    /*******************************************
            //     * 2. Calculate the double precision coefficients
            //     * 
            //     * alpha = (1-sin(fc/fs * 2pi))/cos(fc/fs * 2pi)             
            //     * p0 = ((1+k) + (1-k)*alpha)/2
            //     * p1 = ((k-1) + (k+1)*alpha)/2             
            //     * d1 = alpha
            //    ********************************************/
            //    alpha = (1 - Math.Sin(myFilterSet.Freq * 2 * Math.PI / myFilterSet.FS)) /
            //        Math.Cos(myFilterSet.Freq * 2 * Math.PI / myFilterSet.FS);
            //    p[0] = ((1 + k) + (1 - k) * alpha) / 2;
            //    p[1] = ((k - 1) + (k + 1) * alpha) / 2;
            //    d[1] = alpha;

            //    /*******************************************
            //     * 3. Transfer the double precision coefficients 
            //     * to integer values represented by registers.
            //     * 
            //     * b0 = round(p0 × 2^23)
            //     * b1 = round(p1 × 2^23)
            //     * a0 = round(d1 × 2^23)             
            //    ********************************************/
            //    reg_b[0] = (uint)Math.Round(p[0] * Math.Pow(2, 23));
            //    reg_b[1] = (uint)Math.Round(p[1] * Math.Pow(2, 23));
            //    reg_a[0] = (uint)Math.Round(d[1] * Math.Pow(2, 23));

            //    /*******************************************
            //     * 4. Transfer the decimal integer values 
            //     * to 26-bit, twos complement hex values.
            //    ********************************************/

            //    /*******************************************
            //     * 5. Change the p and d to be used for FR calc
            //     * H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
            //     *******************************************/
            //    d[1] = -d[1];
            //}
            //#endregion 

            //#region high pass shelving
            //else
            //{
            //    /*******************************************
            //    * 1. Transfer the gain in decibels (dB) to decimal domain.
            //    ********************************************/
            //    k = Math.Pow(10, myFilterSet.Gain / 20.0);

            //    /*******************************************
            //     * 2. Calculate the double precision coefficients
            //     * 
            //     * alpha = (1-sin(fc/fs * 2pi))/cos(fc/fs * 2pi)             
            //     * p0 = ((1+k) - (1-k)*alpha)/2
            //     * p1 = ((1-k) - (1+k)*alpha)/2             
            //     * d1 = alpha
            //    ********************************************/
            //    alpha = (1 - Math.Sin(myFilterSet.Freq * 2 * Math.PI / myFilterSet.FS)) /
            //        Math.Cos(myFilterSet.Freq * 2 * Math.PI / myFilterSet.FS);
            //    p[0] = ((1 + k) - (1 - k) * alpha) / 2;
            //    p[1] = ((1 - k) - (1 + k) * alpha) / 2;
            //    d[1] = alpha;

            //    /*******************************************
            //     * 3. Transfer the double precision coefficients 
            //     * to integer values represented by registers.
            //     * 
            //     * b0 = round(p0 × 2^23)
            //     * b1 = round(p1 × 2^23)
            //     * a0 = round(d1 × 2^23)             
            //    ********************************************/
            //    reg_b[0] = (uint)Math.Round(p[0] * Math.Pow(2, 23));
            //    reg_b[1] = (uint)Math.Round(p[1] * Math.Pow(2, 23));
            //    reg_a[0] = (uint)Math.Round(d[1] * Math.Pow(2, 23));

            //    /*******************************************
            //     * 4. Transfer the decimal integer values 
            //     * to 26-bit, twos complement hex values.
            //    ********************************************/

            //    /*******************************************
            //     * 5. Change the p and d to be used for FR calc
            //     * H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
            //     *******************************************/
            //    d[1] = -d[1];
            //}
            //#endregion 
            #endregion 

            #region Low pass shelving
            if (low_high == FilterSubType_Shelving.Low)
            {
                /*******************************************
                * 1. Transfer the gain in decibels (dB) to decimal domain.
                ********************************************/
                //k = Math.Pow(10, myFilterSet.Gain / 20.0);

                /*******************************************
                 * 2. Calculate the double precision coefficients
                 * 
                 * A = sqrt(10^(G/20))
                 * wc = fc/fs * 2pi
                 * k = sin(wc)/sqrt(2)
                 * b0 = A*((A+1)-(A-1)*cos(wc)+2*sqrt(A)*K)
                 * b1 = 2*A((A-1)-(A+1)*cos(wc))
                 * b2 = A*((A+1)-(A-1)*cos(wc)-2*sqrt(A)*K)
                 * a0 = (A+1)+(A-1)*cos(wc)+2*sqrt(A)*K
                 * a1 = -2*((A-1)+(A+1)*cos(wc))
                 * a2 = (A+1)+(A-1)*cos(wc)-2*sqrt(A)*K
                 * 
                 * p0 = b0/a0
                 * p1 = b1/a0
                 * p2 = b2/a0
                 * d1 = -a1/a0
                 * d2 = -a2/a0
                ********************************************/
                double A = Math.Sqrt(Math.Pow(10, myFilterSet.Gain / 20));
                wc = myFilterSet.Freq * 2 * Math.PI / myFilterSet.FS;
                k = Math.Sin(wc) / Math.Sqrt(2);
                double a0 = (A + 1) + (A - 1) * Math.Cos(wc) + 2 * Math.Sqrt(A) * k;
                p[0] = (A * ((A + 1) - (A - 1) * Math.Cos(wc) + 2 * Math.Sqrt(A) * k)) / a0;
                p[1] = (2 * A * ((A - 1) - (A + 1) * Math.Cos(wc))) / a0;
                p[2] = (A * ((A + 1) - (A - 1) * Math.Cos(wc) - 2 * Math.Sqrt(A) * k)) / a0;
                d[1] = (2 * ((A - 1) + (A + 1) * Math.Cos(wc))) / a0;
                d[2] = -((A + 1) + (A - 1) * Math.Cos(wc) - 2 * Math.Sqrt(A) * k) / a0;
                
                /*******************************************
                 * 3. Transfer the double precision coefficients 
                 * to integer values represented by registers.
                 * 
                 * b0 = round(p0 × 2^23)
                 * b1 = round(p1 × 2^23)
                 * b2 = round(p2 × 2^23)
                 * a0 = round(d1 × 2^23)
                 * a1 = round(d2 × 2^23)
                ********************************************/
                reg_b[0] = (uint)Math.Round(p[0] * Math.Pow(2, 23));
                reg_b[1] = (uint)Math.Round(p[1] * Math.Pow(2, 23));
                reg_b[2] = (uint)Math.Round(p[2] * Math.Pow(2, 23));
                reg_a[0] = (uint)Math.Round(d[1] * Math.Pow(2, 23));
                reg_a[1] = (uint)Math.Round(d[2] * Math.Pow(2, 23));

                /*******************************************
                 * 4. Transfer the decimal integer values 
                 * to 26-bit, twos complement hex values.
                ********************************************/

                /*******************************************
                 * 5. Change the p and d to be used for FR calc
                 * H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
                 *******************************************/
                d[1] = -d[1];
                d[2] = -d[2];

                /*******************************************
                 * example: 
                 * when fc = 1KHz, g = 6dB, fs = 48KHz
                 * P0*2^23 = 8661797
                 * P1*2^23 = -15425281
                 * P2*2^23 = 6951835
                 * D1*2^23 = 15472257 
                 * D2*2^23= -7178048
                 *******************************************/
            }
            #endregion

            #region high pass shelving
            else
            {
                /*******************************************
                * 1. Transfer the gain in decibels (dB) to decimal domain.
                ********************************************/
                //k = Math.Pow(10, myFilterSet.Gain / 20.0);

                /*******************************************
                 * 2. Calculate the double precision coefficients
                 * 
                 * A = sqrt(10^(G/20))
                 * wc = fc/fs * 2pi
                 * k = sin(wc)/sqrt(2)
                 * b0 = A*((A+1)+(A-1)*cos(wc)+2*sqrt(A)*K)
                 * b1 = -2*A*((A-1)+(A+1)*cos(wc))
                 * b2 = A*((A+1)+(A-1)*cos(wc)-2*sqrt(A)*K)
                 * a0 = (A+1)+(A-1)*cos(wc)+2*sqrt(A)*K
                 * a1 = -2*((A-1)+(A+1)*cos(wc))
                 * a2 = (A+1)+(A-1)*cos(wc)-2*sqrt(A)*K
                 * 
                 * p0 = b0/a0
                 * p1 = b1/a0
                 * p2 = b2/a0
                 * d1 = -a1/a0
                 * d2 = -a2/a0
                ********************************************/
                double A = Math.Sqrt(Math.Pow(10, myFilterSet.Gain / 20));
                wc = myFilterSet.Freq * 2 * Math.PI / myFilterSet.FS;
                k = Math.Sin(wc) / Math.Sqrt(2);
                double a0 = (A + 1) + (A - 1) * Math.Cos(wc) + 2 * Math.Sqrt(A) * k;
                p[0] = (A * ((A + 1) + (A - 1) * Math.Cos(wc) + 2 * Math.Sqrt(A) * k)) / a0;
                p[1] = (-2 * A * ((A - 1) + (A + 1) * Math.Cos(wc))) / a0;
                p[2] = (A * ((A + 1) + (A - 1) * Math.Cos(wc) - 2 * Math.Sqrt(A) * k)) / a0;
                d[1] = (-2 * ((A - 1) - (A + 1) * Math.Cos(wc))) / a0;
                d[2] = -((A + 1) - (A - 1) * Math.Cos(wc) - 2 * Math.Sqrt(A) * k) / a0;

                /*******************************************
                 * 3. Transfer the double precision coefficients 
                 * to integer values represented by registers.
                 * 
                 * b0 = round(p0 × 2^23)
                 * b1 = round(p1 × 2^23)
                 * b2 = round(p2 × 2^23)
                 * a0 = round(d1 × 2^23)
                 * a1 = round(d2 × 2^23)
                ********************************************/
                reg_b[0] = (uint)Math.Round(p[0] * Math.Pow(2, 23));
                reg_b[1] = (uint)Math.Round(p[1] * Math.Pow(2, 23));
                reg_b[2] = (uint)Math.Round(p[2] * Math.Pow(2, 23));
                reg_a[0] = (uint)Math.Round(d[1] * Math.Pow(2, 23));
                reg_a[1] = (uint)Math.Round(d[2] * Math.Pow(2, 23));

                /*******************************************
                 * 4. Transfer the decimal integer values 
                 * to 26-bit, twos complement hex values.
                ********************************************/

                /*******************************************
                 * 5. Change the p and d to be used for FR calc
                 * H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
                 *******************************************/
                d[1] = -d[1];
                d[2] = -d[2];

                /*******************************************
                 * example: 
                 * when fc = 1KHz, g = 6dB, fs = 48KHz
                 * P0*2^23 = 16209582
                 * P1*2^23 = --29897549
                 * P2*2^23 = 13870376
                 * D1*2^23 = 14938776 
                 * D2*2^23= -6732577
                 *******************************************/
            }
            #endregion 

        }

        /// <summary>
        /// H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
        /// fC as the required notch filter center frequency
        /// fc as the required peak filter center frequency, 
        /// BW as the bandwidth, 
        /// use the following steps for coefficient calculation:
        /// </summary>
        void CoeffCalc_Notch()
        {
            /*******************************************
            * 1. Transfer the gain in decibels (dB) to decimal domain.
            ********************************************/

            /*******************************************
             * 2. Calculate the double precision coefficients
             * 
             * k = (2*tan(BW/fs * pi))/(1+cos(fc/fs * 2pi))             
             * p0 = 1/(1-k)
             * p1 = 2*cos(fc/fs * 2pi)/(k-1)
             * p2 = 1/(1-k)
             * d1 = -2cos(fc/fs * 2pi)/(k-1)
             * d2 = -(1+k)/(1-k)
            ********************************************/
            k = (2 * Math.Tan(myFilterSet.BandWidth * Math.PI / myFilterSet.FS)) / (1 + Math.Cos(myFilterSet.Freq * 2 * Math.PI / myFilterSet.FS));
            p[0] = 1 / (1 - k);
            p[1] = (2 * Math.Cos(myFilterSet.Freq * 2 * Math.PI / myFilterSet.FS)) / (k - 1);
            p[2] = 1 / (1 - k);
            d[1] = (-2 * Math.Cos(myFilterSet.Freq * 2 * Math.PI / myFilterSet.FS)) / (k - 1);
            d[2] = -(1 + k) / (1 - k);

            /*******************************************
             * 3. Transfer the double precision coefficients 
             * to integer values represented by registers.
             * 
             * b0 = round(p0 × 2^23)
             * b1 = round(p1 × 2^23)
             * b2 = round(p2 × 2^23)
             * a0 = round(d1 × 2^23)
             * a1 = round(d2 × 2^23)
            ********************************************/
            reg_b[0] = (uint)Math.Round(p[0] * Math.Pow(2, 23));
            reg_b[1] = (uint)Math.Round(p[1] * Math.Pow(2, 23));
            reg_b[2] = (uint)Math.Round(p[2] * Math.Pow(2, 23));
            reg_a[0] = (uint)Math.Round(d[1] * Math.Pow(2, 23));
            reg_a[1] = (uint)Math.Round(d[2] * Math.Pow(2, 23));

            /*******************************************
             * 4. Transfer the decimal integer values 
             * to 26-bit, twos complement hex values.
            ********************************************/

            /*******************************************
             * 5. Change the p and d to be used for FR calc
             * H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
             *******************************************/
            d[1] = -d[1];
            d[2] = -d[2];

            /*******************************************
             * example: 
             * when fc = 1KHz, fs = 48KHz, bw = 200Hz,
             * P0*2^23 = 8500362
             * P1*2^23 = -16855280
             * P2*2^23 = 8500362
             * D1*2^23 = 16855280 
             * D2*2^23= -8612116
             *******************************************/
        }

        /// <summary>
        /// H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
        /// fs as the input signal sampling frequency, 
        /// fc as the center frequency, 
        /// use the following steps for coefficient calculation:
        /// <param name="_type">The subType can be one of General, Butterworth, Bessel</param>
        /// </summary>
        void CoeffCalc_LowPass(FilterSubType_LoHiPass _type)
        {
            #region Butterworth low pass filter
            if (_type == FilterSubType_LoHiPass.Butterworth)
            {
                /*******************************************
                * 1. Transfer the gain in decibels (dB) to decimal domain.
                ********************************************/

                /*******************************************
                 * 2. Calculate the double precision coefficients
                 * 
                 * wc = fc/fs * 2pi
                 * k = sin(wc)/sqrt(2)
                 * b0 = (1-cos(wc))/2
                 * b1 = 1-cos(wc)
                 * b2 = (1-cos(wc))/2
                 * a0 = 1+k
                 * a1 = -2*cos(wc)
                 * a2 = 1-k
                 * p0 = b0/a0
                 * p1 = b1/a0
                 * p2 = b2/a0
                 * d1 = -a1/a0
                 * d2 = -a2/a0
                ********************************************/
                wc = (myFilterSet.Freq * 2 * Math.PI) / myFilterSet.FS;
                k = Math.Sin(wc) / Math.Sqrt(2);
                double a0 = 1 + k;
                p[0] = (1 - Math.Cos(wc)) / (2 * a0);
                p[1] = (1 - Math.Cos(wc)) / a0;
                p[2] = (1 - Math.Cos(wc)) / (2 * a0);
                d[1] = (2 * Math.Cos(wc)) / a0;
                d[2] = (k - 1) / a0;

                /*******************************************
                 * 3. Transfer the double precision coefficients 
                 * to integer values represented by registers.
                 * 
                 * b0 = round(p0 × 2^23)
                 * b1 = round(p1 × 2^23)
                 * b2 = round(p2 × 2^23)
                 * a0 = round(d1 × 2^23)
                 * a1 = round(d2 × 2^23)
                ********************************************/
                reg_b[0] = (uint)Math.Round(p[0] * Math.Pow(2, 23));
                reg_b[1] = (uint)Math.Round(p[1] * Math.Pow(2, 23));
                reg_b[2] = (uint)Math.Round(p[2] * Math.Pow(2, 23));
                reg_a[0] = (uint)Math.Round(d[1] * Math.Pow(2, 23));
                reg_a[1] = (uint)Math.Round(d[2] * Math.Pow(2, 23));

                /*******************************************
                 * 4. Transfer the decimal integer values 
                 * to 26-bit, twos complement hex values.
                ********************************************/

                /*******************************************
                 * 5. Change the p and d to be used for FR calc
                 * H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
                 *******************************************/
                d[1] = -d[1];
                d[2] = -d[2];

                /*******************************************
                 * example: 
                 *  when fc = 1KHz, fs = 48KHz
                 *  P0*2^23 = 32851
                 *  P1*2^23 = 65702
                 *  P2*2^23 = 32851
                 *  D1*2^23 = 15228185 
                 *  D2*2^23= -6970980
                 *******************************************/
            }
            #endregion general
        }

        /// <summary>
        /// H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
        /// fs as the input signal sampling frequency, 
        /// fc as the center frequency, 
        /// use the following steps for coefficient calculation:
        /// <param name="_type">The subType can be one of General, Butterworth, Bessel</param>
        /// </summary>
        void CoeffCalc_HighPass(FilterSubType_LoHiPass _type)
        {
            #region Butterworth high pass filter
            if (_type == FilterSubType_LoHiPass.Butterworth)
            {
                /*******************************************
                * 1. Transfer the gain in decibels (dB) to decimal domain.
                ********************************************/

                /*******************************************
                 * 2. Calculate the double precision coefficients
                 * 
                 * wc = fc/fs * 2pi
                 * k = sin(wc)/sqrt(2)
                 * b0 = (1+cos(wc))/2
                 * b1 = -(1+cos(wc))
                 * b2 = (1+cos(wc))/2
                 * a0 = 1+k
                 * a1 = -2*cos(wc)
                 * a2 = 1-k
                 * p0 = b0/a0
                 * p1 = b1/a0
                 * p2 = b2/a0
                 * d1 = -a1/a0
                 * d2 = -a2/a0
                ********************************************/
                wc = (myFilterSet.Freq * 2 * Math.PI) / myFilterSet.FS;
                k = Math.Sin(wc) / Math.Sqrt(2);
                double a0 = 1 + k;
                p[0] = (1 + Math.Cos(wc)) / (2 * a0);
                p[1] = -(1 + Math.Cos(wc)) / a0;
                p[2] = (1 + Math.Cos(wc)) / (2 * a0);
                d[1] = (2 * Math.Cos(wc)) / a0;
                d[2] = (k - 1) / a0;

                /*******************************************
                 * 3. Transfer the double precision coefficients 
                 * to integer values represented by registers.
                 * 
                 * b0 = round(p0 × 2^23)
                 * b1 = round(p1 × 2^23)
                 * b2 = round(p2 × 2^23)
                 * a0 = round(d1 × 2^23)
                 * a1 = round(d2 × 2^23)
                ********************************************/
                reg_b[0] = (uint)Math.Round(p[0] * Math.Pow(2, 23));
                reg_b[1] = (uint)Math.Round(p[1] * Math.Pow(2, 23));
                reg_b[2] = (uint)Math.Round(p[2] * Math.Pow(2, 23));
                reg_a[0] = (uint)Math.Round(d[1] * Math.Pow(2, 23));
                reg_a[1] = (uint)Math.Round(d[2] * Math.Pow(2, 23));

                /*******************************************
                 * 4. Transfer the decimal integer values 
                 * to 26-bit, twos complement hex values.
                ********************************************/

                /*******************************************
                 * 5. Change the p and d to be used for FR calc
                 * H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
                 *******************************************/
                d[1] = -d[1];
                d[2] = -d[2];

                /*******************************************
                 * Example: when fc = 1KHz, fs = 48KHz
                 * P0*2^23 = 7646943
                 * P1*2^23 = -15293886
                 * P2*2^23 = 7646943
                 * D1*2^23 = 15228185 
                 * D2*2^23= -6970980
                 *******************************************/
            }
            #endregion general
        }

        #endregion Coefficents Calculation

        #region Frequency Response Calculation
        /// <summary>
        /// This function is used to calculated the frequency response based on 
        /// current coefficents and frequency points.
        /// </summary>
        /// <param name="_freqs">Frequency point will be used to calculated FR.</param>
        /// <param name="order">Decides 1 or 2 order filter will be calculated</param>
        /// <returns></returns>
        private double[] FrequenctResponse(double[] _freqs, int order)
        {
            double[] fr_out = new double[_freqs.Length];
            double[] phase_out = new double[_freqs.Length];

            // 归一化频率点
            double[] freqs = new double[_freqs.Length];
            for (int ix = 0; ix < _freqs.Length; ix++)
            {
                freqs[ix] = _freqs[ix] / Setting.FS;
            }

            int numOrder = 2;
            int denOrder = 2;
            int mySign = 2;         // use the db formate, x for FR, y for pahse shifting.
            double[] num;
            double[] den;
            if (order == 1)
            {
                // 1st filter transer function: 
                //eg. H(Z) = (p0 + p1 * Z-1)/(1 - d1 * Z-1)
                numOrder = 1;
                denOrder = 1;
                num = new double[] { p[0], p[1] };
                den = new double[] { 1, d[1]};

            }
            else
            {
                // 2nd filter transer function: 
                //eg. H(Z) = (p0 + p1 * Z-1 + p2 * Z-2)/(1 - d1 * Z-1 - d2 * Z-2)
                num = new double[] { p[0], p[1], p[2] };
                den = new double[] { 1, d[1], d[2] };
            }
            TransferFunc.FilterTF(num, den, numOrder, denOrder, fr_out, phase_out, freqs, mySign);

            #region Test code
            //double[] x_out = new double[200];
            //double[] y_out = new double[200];
            //num = new double[] { p[0], p[1], p[2] };
            //den = new double[] { 1, -d[0], -d[1] };
            //numOrder = 2;
            //denOrder = 2;
            //mySign = 2;         // use the db formate, x for FR, y for pahse shifting.
            //TransferFunc.FilterTF(num, den, numOrder, denOrder, x_out, y_out, 200, mySign);
            #endregion 

            return fr_out;
        }
        #endregion 

        #region Properties
        public double[] A
        {
            //set { p = value; }
            get { return p; }
        }

        public double[] B
        {
            //set { d = value; }
            get { return d; }
        }

        public uint[] RegValue_B
        {
            get { return this.reg_b; }
        }

        public uint[] RegValue_A
        {
            get { return this.reg_a; }
        }

        //public double FS
        //{
        //    //set { fs = value; }
        //    get { return fs; }
        //}

        //public double F0
        //{
        //    //set { fc = value; }
        //    get { return fc; }
        //}

        //public double Gain_dB
        //{
        //    //set 
        //    //{
        //    //    gain_dB = value;
        //    //    gain_linear = Math.Pow(10.0, gain_dB / 20.0);
        //    //}
        //    get { return gain_dB; }
        //}

        //public double Q_Factor
        //{
        //    //set { q_factor = value; }
        //    get { return q_factor; }
        //}

        public List<double> FR_Mag_out
        {
            get { return this.fr_Mag_out; }
        }

        public FilterSetting Setting
        {
            get { return this.myFilterSet; }
            set 
            {
                this.myFilterSet = value;
            }
        }
        #endregion Properties
    }

    [Serializable]
    public enum FilterType
    {
        AllPass = 0,
        Peaking = 1,
        LowPass = 2,
        HighPass = 3,
        Shelving = 4,
        Notch    = 5
    }

    [Serializable]
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

    [Serializable]
    public enum FilterSubType_LoHiPass
    {
        General = 1,
        Butterworth = 2,
        Bessel = 3
    }

    [Serializable]
    public enum FilterSubType_Shelving
    {
        Low = 10,
        High = 11
    }

    [Serializable]
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

        double fs = 48000;
        public double FS
        {
            get { return this.fs; }
            set { this.fs = value; }
        }

        double freq = 20;
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
