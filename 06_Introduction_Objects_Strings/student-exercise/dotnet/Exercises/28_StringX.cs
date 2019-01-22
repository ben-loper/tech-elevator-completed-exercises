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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string result = "";

            if(str.Length == 1)
            {
                result = str;
            } else if (str.Length > 1)
            {
                result += str.Substring(0, 1);

                string[] resultArray = str.Substring(1, str.Length - 2).Split("x");

                for (int i = 0; i < resultArray.Length; i++)
                {
                    result += resultArray[i];
                }

                result += str.Substring(str.Length - 1);
            }
            return result;
        }
    }
}
