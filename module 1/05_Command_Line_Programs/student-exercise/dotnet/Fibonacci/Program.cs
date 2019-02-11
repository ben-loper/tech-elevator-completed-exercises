using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        /*
         * The Fibonacci numbers are the integers in the following sequence:

            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...

            By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.

            Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.

            ```
            Please enter the Fibonacci number: 25

            0, 1, 1, 2, 3, 5, 8, 13, 21
            ```
         */
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
              
                Console.Write("Please enter the Fibonacci number: ");
                int givenValue = int.Parse(Console.ReadLine());

                if (givenValue == 0 || givenValue == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("0, 1, 1");
                }
                else
                {
                    int[] results = FindFibonacciSequence(givenValue);

                    Console.WriteLine();
                    Console.Write(results[0]);
                    for (int i = 1; i < results.Length; i++)
                    {
                        Console.Write($", {results[i]}");
                    }
                    Console.WriteLine();
                }   
                
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }


        public static int[] FindFibonacciSequence(int givenValue)
        {            
            var fibonacciNumbers = new List<int> { 0, 1, };
            int i = 1;

            //Loop through the list adding the previous 2 values, adding the result
            //of the operation to the list of integers until the result of the 
            //addition is greater than or equal to the given integer value

            while (fibonacciNumbers[i] < givenValue)
            {
                fibonacciNumbers.Add(fibonacciNumbers[i] + fibonacciNumbers[i - 1]);
                i++;
            }

            //Removes the last value entered in to the list as long as the list
            //is greater than 2 values in length and the value is not equal
            //to the given value

            if (fibonacciNumbers.Count > 3 && fibonacciNumbers[i] != givenValue)
            {
                fibonacciNumbers.RemoveRange(i, 1);
            }

            int[] results = InsertValuesIntoArray(fibonacciNumbers);

            return results;
        }

        public static int[] InsertValuesIntoArray(List<int> fibonacciNumbers)
        {
            int[] results = new int[fibonacciNumbers.Count];

            //Loops through the given list and assigns the corresponding
            //array position the value in that 
            for (int i = 0; i < fibonacciNumbers.Count; i++)
            {
                results[i] = fibonacciNumbers[i];
            }

            return results;
        }
    }
}
