using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGM4711_Eva.MDCommon.Filter
{
    public class Complex
    {
        public double Real = 0;
        public double Imagin = 0;

        public Complex()
        {
            this.Real = 0;
            this.Imagin = 0;
        }

        public Complex(double Real, double ImaginPart)
        {
            this.Real = Real;
            this.Imagin = ImaginPart;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imagin + b.Imagin);
        }

        static public Complex operator -(Complex a)
        {
            return new Complex(-a.Real, -a.Imagin);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imagin - b.Imagin);
        }

        static public Complex operator *(Complex a, Complex b)
        {
            return new Complex((a.Real * b.Real) - (a.Imagin * b.Imagin),
                (a.Real * b.Imagin) + (a.Imagin * b.Real));
        }

        static public Complex operator *(double a, Complex b)
        {
            return new Complex(a * b.Real, a * b.Imagin);
        }

        static public Complex operator *(Complex a, double b)
        {
            return new Complex(a.Real * b, a.Real * b);
        }

        static public Complex operator /(Complex a, Complex b)
        {
            Complex result = new Complex();
            Complex Conjugal = new Complex(b.Real, -b.Imagin);
            double denominator = (b.Real * b.Real) + (b.Imagin * b.Imagin);
            result = a * Conjugal;
            result.Real /= denominator;
            result.Imagin /= denominator;
            return result;
        }
        public override string ToString()
        {
            return (Imagin > 0) ? (Real.ToString()) : (String.Format("{0} + {1}i", Real, Imagin));
        }

    }
}
