using System;
using System.Collections.Generic;
using System.Text;

namespace FizzWriter
{
    public abstract class FizzBuzz
    {
        public static string FizzBuzzBuilder(int num)
        {
            string result = num.ToString();

            bool isDivisibleBy5 = IsDivisibleByFive(num);
            bool isDivisibleBy3 = IsDivisibleByThree(num);
            
            if (isDivisibleBy5 && isDivisibleBy3)
            {
                result = "FizzBuzz";
            }
            else if(isDivisibleBy3)
            {
                result = "Fizz";
            }
            else if (isDivisibleBy5)
            {
                result = "Buzz";
            }

            return result;
        }


        private static bool IsDivisibleByFive(int num)
        {
            bool result = false;

            if(num % 5 == 0)
            {
                result = true;
            }

            return result;
        }

        private static bool IsDivisibleByThree(int num)
        {
            bool result = false;

            if (num % 3 == 0)
            {
                result = true;
            }

            return result;
        }
    }
}
