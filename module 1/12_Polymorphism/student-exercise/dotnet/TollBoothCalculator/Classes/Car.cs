using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehicle
    {
        public bool HasTrailer { get; }

        public Car(bool hasTrailer)
        {
            HasTrailer = hasTrailer;
        }

        public double CalculateToll(int distance)
        {
            double distanceRate = 0.020;

            double toll = distance * distanceRate;

            if (HasTrailer)
            {
                toll += 1;
            }

            return toll;
        }
    }
}
