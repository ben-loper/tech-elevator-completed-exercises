using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        public int Result { get; private set; }

        public Calculator(int startingResult)
        {
            Result = startingResult;
        }

        public int Add(int addend)
        {
            return Result += addend;
        }

        public int Subtract(int subtrahend)
        {
            return Result -= subtrahend;
        }

        public int Multiply(int multiplier)
        {
            return Result *= multiplier;
        }

        public int Power(int exponent)
        {
            double doubleResult = Result;

            if (exponent < 0)
            {
                exponent = -1 * exponent;
            }

            doubleResult = Math.Pow(doubleResult, exponent);

            Result = (int)doubleResult;

            return Result;
        }

        public void Reset()
        {
            Result = 0;
        }
    }
}
