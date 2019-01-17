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
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            int result = 0;
            bool aIsInRange = a >= 10 && a <= 20;
            bool bIsInRange = b >= 10 && b <= 20;

            if (aIsInRange || bIsInRange)
            {
                if (!aIsInRange)
                {
                    result = b;
                } else if (!bIsInRange)
                {
                    result = a;
                } else if (a > b)
                {
                    result = a;
                } else
                {
                    result = b;
                }
            }

            return result;
        }

    }
}
