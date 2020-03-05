using System;

namespace Calculator.bl
{
    public class Calculator
    {
        public int RoundDigits { get; }
        public Calculator(int roundDigits)
        {
            if (roundDigits < 0 || roundDigits >= 8)
            {
                throw new ArgumentException("Round must be less than 8 and more than 0");
            }

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

     
        public double Division(double right, double left)
        {
            if (left == 0)
            {
                throw new ArgumentException("Left is 0",nameof(left));
            }


            return Math.Round(right / left, RoundDigits);
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
