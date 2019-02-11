using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return the count of the number of times that a substring length 2 appears in the string and
         also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
         Last2("hixxhi") → 1
         Last2("xaxxaxaxx") → 1
         Last2("axxxaaxx") → 2
         */
        public int Last2(string str)
        {
            int result = 0;

            if (str.Length >= 2)
            {
                string twoCharComparision = str.Substring(str.Length - 2, 2);

                char[] tempCharArray = str.ToCharArray();


                for (int i = 1; i <= tempCharArray.Length - 2; i++)
                {


                    if (tempCharArray[i - 1].ToString() + tempCharArray[i].ToString() == twoCharComparision)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
