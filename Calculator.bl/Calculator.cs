using System;

namespace Calculator.bl
{
    public class Calculator
    {
        public int RoundDigits { get; }
        public Calculator (int roundDigits)
        {
            RoundDigits = roundDigits;
        }

       public double Sum(double x, double y)
        {
            return Math.Round(x + y, RoundDigits);
        }

        public double Minus(double x, double y)
        {
            return Math.Round(x - y, RoundDigits); 
        }
        public double Division(double x, double y)
        {
            return Math.Round(x / y, RoundDigits);
        }

        public double Multiplication(double x, double y)
        {
            return Math.Round(x * y, RoundDigits);
        }

        public double Squaring(double x)
        {
            return Math.Round(x * x, RoundDigits);
        }

        public double Sqrt(double x)
        {
            double v = Math.Round(Math.Sqrt(x), RoundDigits);
            return v;
        }
    }
}
