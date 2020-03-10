using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.bl
{
   public interface IRoundStrategy
    {
        int RoundDigits { get; }

        MidpointRounding Rounding { get; }
    }
}
