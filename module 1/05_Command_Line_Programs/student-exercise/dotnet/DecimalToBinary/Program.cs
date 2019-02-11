using System;

namespace DecimalToBinary
{
    class Program
    {
        /*
            Write a command line program which prompts the user for a series of decimal integer values separated by spaces. Each decimal integer is displayed along with its equivalent binary value.

            ```
            Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321

            460 in binary is 111001100
            8218 in binary is 10000000011010
            1 in binary is 1
            31313 in binary is 111101001010001
            987654321 in binary is 111010110111100110100010110001
            ```
         */

        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();

                Console.Write("Please enter in a series of decimal values (separated by spaces): ");
                string userInput = Console.ReadLine();

                PrintResults(userInput);

                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        public static string ConvertDecimalToBinary(int givenValue)
        {
            //Divide the input decimal number by 2 and store the remainder.

            decimal remainder = givenValue % 2;

            //Store the quotient back to the input number variable.
            decimal quotient = givenValue / 2;

            string binaryEquivalent = remainder.ToString();

            //Repeat this process till quotient becomes zero.
            while (quotient != 0)
            {
                givenValue = (int)(quotient);
                remainder = givenValue % 2;
                quotient = givenValue / 2;
                binaryEquivalent = remainder.ToString() + binaryEquivalent;
            }

            return binaryEquivalent;
        }
        
        public static void PrintResults(string giveValues)
        {
            string[] enteredValues = giveValues.Split(' ');
            int[] enteredValuesNumbers = new int[enteredValues.Length];

            Console.WriteLine();
            for (int i = 0; i < enteredValues.Length; i++)
            {
                enteredValuesNumbers[i] = int.Parse(enteredValues[i]);
                Console.WriteLine($"{enteredValuesNumbers[i]} in binary is {ConvertDecimalToBinary(enteredValuesNumbers[i])}");
            }
        }
    }
}
