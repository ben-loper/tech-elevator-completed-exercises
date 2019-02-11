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
         Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
         StringBits("Hello") → "Hlo"
         StringBits("Hi") → "H"
         StringBits("Heeololeo") → "Hello"
         */
        public string StringBits(string str)
        {
            char[] tempArray = str.ToCharArray();
            string result = "";

            for(int i = 0; i < tempArray.Length; i += 2)
            {
                result += tempArray[i];
            }

            return result;
        }
    }
}
