using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
        public int NumberOfAxles { get; }

        public Truck(int numberOfAxles)
        {
            NumberOfAxles = numberOfAxles;
        }

        public double CalculateToll(int distance)
        {
            double ratePerMile = 0.048;

            if(NumberOfAxles == 4)
            {
                ratePerMile = 0.040;

            } else if(NumberOfAxles == 6)
            {
                ratePerMile = 0.045;
            }


            return ratePerMile * distance ;
        }
    }
}
