using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class FourDayGround : SPU
    {
        public override double CalculateRate(int distance, double weight)
        {
            double poundConversion = weight / 16;

            return (poundConversion * 0.0050) * distance;
        }
    }
}
