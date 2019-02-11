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
        Given three ints, a b c, one of them is small, one is medium and one is large. Return true if the three values are evenly 
        spaced, so the difference between small and medium is the same as the difference between medium and large.
        evenlySpaced(2, 4, 6) → true
        evenlySpaced(4, 6, 2) → true
        evenlySpaced(4, 6, 3) → false
        */
        public bool EvenlySpaced(int a, int b, int c)
        {
            bool result = false;

            List<int> numsList = new List<int>() { a, b, c };
            numsList.Sort();

            if(numsList[2] - numsList[1] == numsList[1] - numsList[0])
            {
                result = true;
            }

            return result;
        }
    }
}
