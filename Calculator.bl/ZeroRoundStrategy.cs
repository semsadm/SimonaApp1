using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.bl
{
    public class ZeroRoundStrategy : IRoundStrategy
    {
        public int RoundDigits { get; }

        public MidpointRounding Rounding { get; }

        public ZeroRoundStrategy(MidpointRounding rounding)
        {
            RoundDigits = 0;
            Rounding = rounding;
        }
    }
}
