﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an int array length 3, if there is a 2 in the array immediately followed by a 3, set the 3 element to 0. 
         Return the changed array.
         fix23([1, 2, 3]) → [1, 2, 0]
         fix23([2, 3, 5]) → [2, 0, 5]
         fix23([1, 2, 1]) → [1, 2, 1]
         */
        public int[] Fix23(int[] nums)
        {
            List<int> results = new List<int>();

            results.AddRange(nums);

            for(int i = 0; i < 2; i++)
            {
                if(results[i] == 2 && results[i + 1] == 3)
                {
                    results[i + 1] = 0;
                }
            }

            return results.ToArray();
        }
    }
}
