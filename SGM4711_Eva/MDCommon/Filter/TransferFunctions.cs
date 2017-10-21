using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGM4711_Eva.MDCommon.Filter
{
    /// <summary>
    /// Transfer Function calss which will be used to calculate  different kinds of filters. 
    /// </summary>
    class TransferFunc
    {
        /* 计算数字滤波器的频率响应 
        * num 是数字滤波器的分子多项式系数 
        * den 是数字滤波器的分母多项式系数 
        * num_order 是分子多项式的阶数 
        * den_order 是分母多项式的阶数 
        * sign = 0 时，x_out 为频率响应的实部， y_out 为频率响应的虚部 
        * sign = 1 时，x_out 为频率响应的模， y_out 为频率响应的幅角 
        * sign = 2 时，x_out 为以 dB 为单位的频率响应， y_out 为频率响应的幅角 
        * len 为，频率响应的取样点数 
        * Formula: H(z) = (b0 + b1 * Z-1 + b2 * Z-2 ...) / (a0 + a1 * Z-1 + a2 * Z-2...)
        */
        void FilterTF(double[] num, double[] den, int num_order, int den_order,
            double[] x_out, double[] y_out, int len, int sign)
        {
            int i, k;
            double zr, zi;
            double re, im;
            double ar, ai, br, bi;
            double numr, numi;
            double de, temp;
            double freq;
            for (k = 0; k < len; k++)
            {
                freq = 0.5 * k / (len - 1);
                zr = Math.Cos(-2.0 * Math.PI * freq);
                zi = Math.Sin(-2.0 * Math.PI * freq);
                br = 0.0;
                bi = 0.0;
                for (i = num_order; i > 0; i--)
                {
                    re = br;
                    im = bi;
                    br = (re + num[i]) * zr - im * zi;
                    bi = (re + num[i]) * zi + im * zr;
                }
                ar = 0.0;
                ai = 0.0;
                for (i = den_order; i > 0; i--)
                {
                    re = ar;
                    im = ai;
                    ar = (re + den[i]) * zr - im * zi;
                    ai = (re + den[i]) * zi + im * zr;
                }
                br = br + num[0];
                ar = ar + 1.0;
                numr = ar * br + ai * bi;
                numi = ar * bi - ai * br;
                de = ar * ar + ai * ai;
                x_out[k] = numr / de;
                y_out[k] = numi / de;
                switch (sign)
                {
                    case 1:
                        temp = Math_hypot(x_out[k], y_out[k]);
                        y_out[k] = Math.Atan2(y_out[k], x_out[k]);
                        x_out[k] = temp;
                        break;
                    case 2:
                        temp = x_out[k] * x_out[k] + y_out[k] * y_out[k];
                        y_out[k] = Math.Atan2(y_out[k], x_out[k]);
                        x_out[k] = 10 * Math.Log10(temp);
                        break;
                    default:
                        break;
                }
            }
        }

        /* 计算数字滤波器的频率响应 
        * num 是数字滤波器的分子多项式系数 
        * den 是数字滤波器的分母多项式系数 
        * num_order 是分子多项式的阶数 
        * den_order 是分母多项式的阶数 
        * sign = 0 时，x_out 为频率响应的实部， y_out 为频率响应的虚部 
        * sign = 1 时，x_out 为频率响应的模， y_out 为频率响应的幅角 
        * sign = 2 时，x_out 为以 dB 为单位的频率响应， y_out 为频率响应的幅角 
        * len 为，频率响应的取样点数 
        * Formula: H(z) = (b0 + b1 * Z-1 + b2 * Z-2 ...) / (a0 + a1 * Z-1 + a2 * Z-2...)
        */
        void FilterTF(double[] num, double[] den, int num_order, int den_order,
            double[] x_out, double[] y_out, double[] freqs, int sign)
        {
            int ix, ix_freqLoop;
            double zr, zi;
            double re, im;
            double ar, ai, br, bi;
            double numr, numi;
            double de, temp;
            double freq;
            for (ix_freqLoop = 0; ix_freqLoop < freqs.Length; ix_freqLoop++)
            {
                freq = freqs[ix_freqLoop];
                zr = Math.Cos(-2.0 * Math.PI * freq);
                zi = Math.Sin(-2.0 * Math.PI * freq);
                br = 0.0;
                bi = 0.0;
                for (ix = num_order; ix > 0; ix--)
                {
                    re = br;
                    im = bi;
                    br = (re + num[ix]) * zr - im * zi;
                    bi = (re + num[ix]) * zi + im * zr;
                }
                ar = 0.0;
                ai = 0.0;
                for (ix = den_order; ix > 0; ix--)
                {
                    re = ar;
                    im = ai;
                    ar = (re + den[ix]) * zr - im * zi;
                    ai = (re + den[ix]) * zi + im * zr;
                }
                br = br + num[0];
                ar = ar + 1.0;
                numr = ar * br + ai * bi;
                numi = ar * bi - ai * br;
                de = ar * ar + ai * ai;
                x_out[ix_freqLoop] = numr / de;
                y_out[ix_freqLoop] = numi / de;
                switch (sign)
                {
                    case 1:
                        temp = Math_hypot(x_out[ix_freqLoop], y_out[ix_freqLoop]);
                        y_out[ix_freqLoop] = Math.Atan2(y_out[ix_freqLoop], x_out[ix_freqLoop]);
                        x_out[ix_freqLoop] = temp;
                        break;
                    case 2:
                        temp = x_out[ix_freqLoop] * x_out[ix_freqLoop] + y_out[ix_freqLoop] * y_out[ix_freqLoop];
                        y_out[ix_freqLoop] = Math.Atan2(y_out[ix_freqLoop], x_out[ix_freqLoop]);
                        x_out[ix_freqLoop] = 10 * Math.Log10(temp);
                        break;
                    default:
                        break;
                }
            }
        }


        double Math_hypot(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        Complex poly_val(double[] p, int n, double omega)  
        {  
            int i;  
            Complex e_njw, sum;
            sum = new Complex();
            for (i = 0; i < n; i++)  
            {
                e_njw = new Complex(Math.Cos(i * omega), Math.Sin(i * omega));
                sum += p[i] * e_njw;  
            }  
            return sum;  
        }

        void FilterTF(double[] num, double[] den, int num_size, int den_size, Complex[] output, int n)  
        {  
            double omega;  
            int i;  
            for (i = 0; i < n; i++)  
            {  
                omega = Math.PI * i / (n-1);  
                output[i] = poly_val(num, num_size, omega) / poly_val(den, den_size, omega);  
            }  
        }  


    }
    
}
