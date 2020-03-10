using System;

namespace Calculator.bl
{
    public class Calculator
    {
     
        public IRoundStrategy RoundOptions { get; }

        public Calculator(IRoundStrategy roundOptions)
        {
            RoundOptions = roundOptions ?? throw new ArgumentNullException(nameof(roundOptions));
        }

        public double Sum(double x, double y)
        {
            return Math.Round(x + y, RoundOptions.RoundDigits, RoundOptions.Rounding);
        }

       
    }
}
