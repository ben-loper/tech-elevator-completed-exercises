using System;
using System.Collections.Generic;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(new Car(false));
            vehicles.Add(new Tank());
            vehicles.Add(new Truck(4));
            vehicles.Add(new Truck(6));
            vehicles.Add(new Truck(8));
            vehicles.Add(new Tank());
            vehicles.Add(new Car(true));

            int totalMilesTraveled = 0;
            double totalBoothRevenue = 0;

            Console.WriteLine("Vehicle".PadRight(20) + "Distance Traveled".PadRight(20) + "Toll $");
            Console.WriteLine("----------------------------------------------");

            foreach (IVehicle vehicle in vehicles)
            {
                int distanceTraveled = rnd.Next(10, 241);

                totalMilesTraveled += distanceTraveled;

                double toll = 0;

                toll = vehicle.CalculateToll(distanceTraveled);

                Console.WriteLine(DetermineVehicle(vehicle).PadRight(20) + distanceTraveled.ToString().PadRight(20) + toll.ToString("C"));

                totalBoothRevenue += toll;
            }
            Console.WriteLine();
            Console.WriteLine($"Total Miles Traveled: {totalMilesTraveled}");
            Console.WriteLine($"Total Tollbooth Revenue: {totalBoothRevenue.ToString("C")}");
            Console.ReadKey();

            
        }

        public static string DetermineVehicle(IVehicle vehicle)
        {
            string result = "Tank";

            if (vehicle is Car car)
            {
                result = "Car";

                if (car.HasTrailer)
                {
                    result = "Car (with trailer)";

                }
            }

            if (vehicle is Truck truck)
            {
                result = $"Truck ({truck.NumberOfAxles} axels)";
            }

            return result;
        }
    }
}
