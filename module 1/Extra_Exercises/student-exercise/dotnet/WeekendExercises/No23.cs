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
         Given an int array length 2, return true if it does not contain a 2 or 3.
         no23([4, 5]) → true
         no23([4, 2]) → false
         no23([3, 5]) → false
         */
        public bool No23(int[] nums)
        {
            bool result = true;

            foreach (int num in nums)
            {
                if(num == 2 || num == 3)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
