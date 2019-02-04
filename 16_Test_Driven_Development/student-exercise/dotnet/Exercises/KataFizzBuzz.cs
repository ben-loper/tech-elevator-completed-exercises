using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {

        public string FizzBuzz(int num)
        {
            string result = "";

            //If the number is divisible by 3 and 5 OR the number contains
            // the number 5 or 3, return "FizzBuzz"
            if((IsDivisibleByThree(num) && IsDivisibleByFive(num)) || 
                (ContainsThree(num) && ContainsFive(num)))
            {
                result = "FizzBuzz";
            }

            //If the number is divisible by 3 OR the number contains
            // the number 3, return "Fizz"
            else if (IsDivisibleByThree(num) || ContainsThree(num))
            {
                result = "Fizz";
            }

            //If the number is divisible by 5 OR the number contains
            // the number 5, return "Buzz"
            else if (IsDivisibleByFive(num) || ContainsFive(num))
            {
                result = "Buzz";
            }

            //If the number is NOT divisible by 3 and 5 BUT is between 1 and 100
            // return the string equivalent of the number
            else if (IsBetweenOneAndOneHundred(num))
            {
                result = num.ToString();
            }

            if(num == 0)
            {
                result = "";
            }

            return result;
        }

        private bool IsDivisibleByThree(int num)
        {
            return num % 3 == 0;
        }

        private bool IsDivisibleByFive(int num)
        {
            return num % 5 == 0;
        }

        private bool IsBetweenOneAndOneHundred(int num)
        {
            return num >= 1 && num <= 100;
        }

        private bool ContainsThree(int num)
        {
            bool result = false;

            string numString = num.ToString();

            foreach(Char number in numString)
            {
                if(number == '3')
                {
                    result = true;
                }
            }

            return result;
        }

        private bool ContainsFive(int num)
        {
            bool result = false;

            string numString = num.ToString();

            foreach (Char number in numString)
            {
                if (number == '5')
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
