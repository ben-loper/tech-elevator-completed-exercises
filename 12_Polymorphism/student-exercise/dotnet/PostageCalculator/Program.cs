using System;
using System.Collections.Generic;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IDeliveryDriver> deliveries = new List<IDeliveryDriver>();

            deliveries.Add(new FirstClass());
            deliveries.Add(new SecondClass());
            deliveries.Add(new ThirdClass());
            deliveries.Add(new FexEd());
            deliveries.Add(new FourDayGround());

            Console.Write("Please enter the weight of the package: ");
            double packageWeight = double.Parse(Console.ReadLine());

            Console.Write("(P)ounds or (O)unces? ");
            string weightType = Console.ReadLine().ToLower();

            if(weightType == "p")
            {
                packageWeight *= 16;
            }

            Console.Write("What distance will it be travelling? ");
            int travelDistance = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Delivery Method".PadRight(30) + "$ cost");
            Console.WriteLine("---------------------------------------");

            foreach(IDeliveryDriver delivery in deliveries)
            {
                Console.WriteLine(DetermineDelivery(delivery).PadRight(30) + delivery.CalculateRate(travelDistance, packageWeight).ToString("C"));
            }

            Console.ReadKey();
        }

        public static string DetermineDelivery(IDeliveryDriver delivery)
        {
            string result = "Postal Service ";

            if(delivery is FirstClass)
            {
                result += "(1st Class)";

            } else if(delivery is SecondClass)
            {
                result += "(2nd Class)";

            } else if(delivery is ThirdClass)
            {
                result += "(3rd Class)";
            }
            if(delivery is FexEd)
            {
                result = "FexEd";
            }
            if(delivery is SPU)
            {
                result = "SPU ";

                if(delivery is FourDayGround)
                {
                    result += "(4-Day Ground)";
                } else if(delivery is TwoDayBusiness)
                {
                    result += "(2-Day Business)";
                }
            }

            return result;
        }
    }
}
