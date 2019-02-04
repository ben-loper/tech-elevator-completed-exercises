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
         Given three ints, a b c, return true if one of them is 10 or more less than one of the others.
         lessBy10(1, 7, 11) → true
         lessBy10(1, 7, 10) → false
         lessBy10(11, 1, 7) → true
         */
        public bool LessBy10(int a, int b, int c)
        {
            bool result = false;

            if(DiffIsGreaterThanTen(a, b) || DiffIsGreaterThanTen(b, c) || DiffIsGreaterThanTen(a, c))
            {
                result = true;
            }

            return result;
        }

        private bool DiffIsGreaterThanTen(int a, int b)
        {
            bool result = false;

            if(a - b >= 10 || b - a >= 10)
            {
                result = true;
            }

            return result;
        }
    }
}
