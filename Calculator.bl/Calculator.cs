using System;

namespace Calculator.bl
{
    public class Calculator
    {
       public double Sum(double x, double y)
        {
            return x + y;
        }

        public double Minus(double x, double y)
        {
            return x - y; 
        }
        public double Division(double x, double y)
        {
            return x / y;
        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }
    }
}
