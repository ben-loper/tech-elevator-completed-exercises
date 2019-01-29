using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class TwoDayBusiness : SPU
    {
        public override double CalculateRate(int distance, double weight)
        {
            double poundEquality = weight / 16;

            return (poundEquality * 0.0050) * distance;
        }
    }
}
