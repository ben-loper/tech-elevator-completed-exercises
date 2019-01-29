using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class FirstClass : PostalService
    {
        public override double CalculateRate(int distance, double weight)
        {
            double ratePerMile = 0.5;

            if(weight >= 0 && weight <= 2)
            {
                ratePerMile = 0.035;

            } else if(weight >= 3 && weight <= 8)
            {
                ratePerMile = 0.040;

            } else if(weight >= 9 && weight <= 15)
            {
                ratePerMile = 0.047;

            } else if(weight >= 16 && weight <= 48)
            {
                ratePerMile = 0.195;

            } else if(weight >= 64 && weight <= 128)
            {
                ratePerMile = 0.450;
            }

            return distance * ratePerMile ;
        }
    }
}
