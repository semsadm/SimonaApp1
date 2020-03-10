using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.bl
{
   public class ThreeDigitRoundStrategy:IRoundStrategy
    {
        public int RoundDigits { get; }

        public MidpointRounding Rounding { get; }

        public ThreeDigitRoundStrategy(MidpointRounding rounding)
        {
            RoundDigits = 3;
            Rounding = rounding;
        }
    }
}
