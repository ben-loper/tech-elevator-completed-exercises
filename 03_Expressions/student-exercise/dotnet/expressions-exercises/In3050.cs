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
         Given 2 int values, return true if they are both in the range 30..40 inclusive, or they are both
         in the range 40..50 inclusive.
         In3050(30, 31) → true
         In3050(30, 41) → false
         In3050(40, 50) → true
         */
        public bool In3050(int a, int b)
        {
            bool aIsBetween30And40 = Between30And40(a);
            bool bIsBetween30And40 = Between30And40(b);
            bool aIsBetween40And50 = Between40And50(a);
            bool bIsBetween40And50 = Between40And50(b);
            bool result = false;

            if ((aIsBetween30And40 && bIsBetween30And40) || (aIsBetween40And50 && bIsBetween40And50))
            {
                result = true;
            }

            return result;
        }

        public bool Between30And40(int num)
        {
            return num >= 30 && num <= 40;
        }

        public bool Between40And50(int num)
        {
            return num >= 40 && num <= 50;
        }

    }
}
