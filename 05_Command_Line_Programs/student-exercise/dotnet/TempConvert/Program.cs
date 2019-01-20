using System;

namespace TempConvert
{

    /*
     
     The Fahrenheit to Celsius conversion formula is:

        Tc = (Tf - 32) / 1.8

    where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit

    The Celsius to Fahrenheit conversion formula is:

        Tf = Tc * 1.8 + 32

    Write a command line program which prompts a user to enter a temperature, and whether its in degrees (C)elsius or (F)arenheit. Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.

    ```
    Please enter the temperature: 58
    Is the temperature in (C)elcius, or (F)arenheit? F
    58F is 14C.
    ```
     
     */

    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                
                Console.Write("Please enter the temperature: ");

                string enteredValue = Console.ReadLine();

                //This was used while testing for an easy exit
                if (enteredValue == "Q" || enteredValue == "q")
                {
                    exit = true;
                }
                else 
                {
                    int givenValue = int.Parse(enteredValue);

                    Console.Write("Is the temperature in (C)elcius, or (F)arenheit? ");
                    char selectedTemp = char.Parse(Console.ReadLine());

                    char tempConvertedToLabel = OppositeTempType(selectedTemp);

                    int convertedTemp = ConvertTemperature(givenValue, selectedTemp);

                    //Print the given temperature with the given temperature type and it's opposite equivelant
                    Console.WriteLine($"{givenValue}{selectedTemp} is {convertedTemp}{tempConvertedToLabel}");

                    Console.WriteLine("Press any key to continue...");
                    Console.WriteLine("----------------------------");
                    Console.ReadKey();
                } 
            }

        }

        public static int ConvertTemperature(int givenValue, char givenTempType)
        {
            int result;

            if(givenTempType == 'F')
            {
                result = (int)((givenValue - 32) / 1.8);
            }
            else
            {
                result = (int)(givenValue * 1.8 + 32);
            }

            return result;

        }

        public static char OppositeTempType(char givenTempType)
        {
            char result = 'C';

            if(givenTempType == 'C')
            {
                result = 'F';
            }

            return result;
        }
    }
}
