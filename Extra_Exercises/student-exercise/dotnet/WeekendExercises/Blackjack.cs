using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {

        /*
         Given 2 int values greater than 0, return whichever value is nearest to 21 without going over. Return 0 if they both 
         go over.
         blackjack(19, 21) → 21
         blackjack(21, 19) → 21
         blackjack(19, 22) → 19
         */
        public int Blackjack(int a, int b)
        {
            const int HighestScore = 21;
            int result = b;

            bool numAIsBusted = IsBusted(a);
            bool numBIsBusted = IsBusted(b);

            if(numAIsBusted && numBIsBusted)
            {
                result = 0;
            }
            else if(!numAIsBusted && numBIsBusted ^ HighestScore - a < HighestScore - b)
            {
                result = a;
            }
            else if(numAIsBusted && !numBIsBusted ^ HighestScore - b < HighestScore - a)
            {
                result = b;
            }

            return result;
        }
        
        private bool IsBusted(int num)
        {
            const int HighestScore = 21;
            bool result = false;

            if(num > HighestScore)
            {
                result = true;
            }

            return result;
        }
    }
}
