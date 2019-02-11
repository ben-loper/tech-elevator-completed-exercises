using System;

namespace LinearConvert
{
    class Program
    {
        /*
         *  Write a program that converts meters to feet and vice-versa.
            The foot to meter conversion formula is:

                m = f * 0.3048

            The meter to foot conversion formula is:

                f = m * 3.2808399

            Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet. Convert the length to the opposite measurement, and display the old and new measurements to the console.

            ```
            Please enter the length: 58
            Is the measurement in (m)eter, or (f)eet? f
            58f is 17m.
            ``` 
         */
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                
                Console.Write("Please enter the length: ");

                //This was used while testing for an easy exit
                string enteredValue = Console.ReadLine();
                if (enteredValue == "Q" || enteredValue == "q")
                {
                    isRunning = false;
                }
                else
                {
                    int givenValue = int.Parse(enteredValue);

                    Console.Write("Is the measurement in (m)eter, or (f)eet? ");
                    char selectedMeasurement = char.Parse(Console.ReadLine());

                    char measurmentConvertedToLabel = OppositeMeasurementType(selectedMeasurement);

                    int convertedMeasurement = ConvertMeasurement(givenValue, selectedMeasurement);

                    //Print the given length with the given measurement type and it's opposite equivelant
                    Console.WriteLine($"{givenValue}{selectedMeasurement} is {convertedMeasurement}{measurmentConvertedToLabel}");

                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }

        }

        public static int ConvertMeasurement(int givenValue, char givenMeasurementType)
        {
            int result;

            if (givenMeasurementType == 'f')
            {
                result = (int)(givenValue * 0.3048);
            }
            else
            {
                result = (int)(givenValue * 3.2808399);
            }

            return result;

        }

        public static char OppositeMeasurementType(char givenMeasurementType)
        {
            char result = 'f';

            if (givenMeasurementType == 'f')
            {
                result = 'm';
            }

            return result;
        }
    }
    
}
