using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_1
{
    internal class Complex
    {
        public double Real {  get; set; }
        public double Imaginary { get; set; }
        public Complex(double r, double i)
        {
            Real = r;
            Imaginary = i;
        }
        public Complex()
        {
            Real = 0;
            Imaginary = 0;
        }

        public static Complex operator +(Complex left, Complex right)
        {
            var result = new Complex();
            result.Real = left.Real + right.Real;
            result.Imaginary = left.Imaginary + right.Imaginary;
            return result;
        }
        public static Complex operator -(Complex left, Complex right)
        {
            var result = new Complex();
            result.Real = left.Real - right.Real;
            result.Imaginary = left.Imaginary - right.Imaginary;
            return result;
        }
        public override string ToString()
        {
            string result = string.Empty;
            if (Imaginary >= 0)
            {
                result = string.Format("{0}+{1}i", Real, Imaginary);
            }
            else
            {
                result = string.Format("{0}-{1}i", Real, -Imaginary);
            }
                return result;
        }

    }
}
