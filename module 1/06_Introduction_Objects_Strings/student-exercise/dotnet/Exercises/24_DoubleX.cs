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
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            bool result = false;
            bool firstOccurance = false;

            while (!firstOccurance)
            {
                for (int i = 0; i < str.Length; i++)
                {

                    if(i + 1 == str.Length)
                    {
                        i = str.Length;
                    } else if (str[i].ToString() == "x" && str[i + 1].ToString() == "x")
                    {
                        result = true;
                    } else if ((str[i].ToString() == "x"))
                    {
                        firstOccurance = true;
                        i = str.Length;
                    }
                }

                firstOccurance = true;
            }

            return result;
        }
    }
}