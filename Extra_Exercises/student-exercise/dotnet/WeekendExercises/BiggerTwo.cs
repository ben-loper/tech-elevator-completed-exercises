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
         Start with 2 int arrays, a and b, each length 2. Consider the sum of the values in each array. Return the 
         array which has the largest sum. In event of a tie, return a.
         biggerTwo([1, 2], [3, 4]) → [3, 4]
         biggerTwo([3, 4], [1, 2]) → [3, 4]
         biggerTwo([1, 1], [1, 2]) → [1, 2]
         */
        public int[] BiggerTwo(int[] a, int[] b)
        {
            List<int> results = new List<int>();

            if(a[0] + a[1] >= b[0] + b[1])
            {
                results.AddRange(a);
            }
            else
            {
                results.AddRange(b);
            }

            return results.ToArray();
        }
    }
}
