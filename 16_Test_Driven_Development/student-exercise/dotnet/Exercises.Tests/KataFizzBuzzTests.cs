using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{

    [TestClass]
    public class KataFizzBuzzTests
    {
        KataFizzBuzz testObject = new KataFizzBuzz();

        //If the number is divisible by 3, convert the number to the string, "Fizz"
        [TestMethod]
        public void NumberIsDivisibleByThree()
        {
            Assert.AreEqual("Fizz", testObject.FizzBuzz(3), "Test 1: Input was 3");
        }

        //If the number is divisible by 5, convert the number to the string, "Buzz"
        [TestMethod]
        public void NumberDivisibleByFive()
        {
            Assert.AreEqual("Buzz", testObject.FizzBuzz(5), "Test 2: Input was 3");
        }


        //If the number is divisible by 3 AND 5, convert the number to the string, "FizzBuzz"
        [TestMethod]
        public void NumberDivisibleByThreeAndFive()
        {
            Assert.AreEqual("FizzBuzz", testObject.FizzBuzz(15), "Test 3: Input was 15");
        }

        //For all other numbers between 1 and 100(inclusive), simply convert the number to a string
        [TestMethod]
        public void NumBetweenOneAndOneHundreAndNotDivisibleBy3And5()
        {
            Assert.AreEqual("11", testObject.FizzBuzz(11), "Test 4: Input was 2");
        }

        //Any number that is not between 1 and 100(inclusive), convert the number to an empty string
        [TestMethod]
        public void NumNotBetweenOneAndOneHundred()
        {
            Assert.AreEqual("", testObject.FizzBuzz(-1), "Test 4: Input was -1");
            Assert.AreEqual("", testObject.FizzBuzz(0), "Test 5: Input was 0");
            Assert.AreEqual("", testObject.FizzBuzz(101), "Test 6: Input was 101");
        }


        //If it is number is not divisible by 3 or 5 but contains a 3, convert the number to the string, "Fizz"
        [TestMethod]
        public void NumConatainsThree()
        {
            Assert.AreEqual("Fizz", testObject.FizzBuzz(13), "Test 7: Input was 13");
            Assert.AreEqual("Fizz", testObject.FizzBuzz(314), "Test 8: Input was 314");
            Assert.AreEqual("Fizz", testObject.FizzBuzz(131), "Test 9: Input was 131");
            Assert.AreEqual("Fizz", testObject.FizzBuzz(113), "Test 10: Input was 113");
        }

        //If it is number is not divisible by 3 or 5 but contains a 5, convert the number to the string, "Buzz"
        [TestMethod]
        public void NumConatainsFive()
        {
            Assert.AreEqual("Buzz", testObject.FizzBuzz(511), "Test 7: Input was 511");
            Assert.AreEqual("Buzz", testObject.FizzBuzz(151), "Test 8: Input was 151");
        }

        //If it is number is not divisible by 3 or 5 but contains a 5 AND a 3, convert the number to the string, "FizzBuzz"
        [TestMethod]
        public void NumConatainsFiveAndThree()
        {
            Assert.AreEqual("FizzBuzz", testObject.FizzBuzz(523), "Test 7: Input was 511");
            Assert.AreEqual("FizzBuzz", testObject.FizzBuzz(15132), "Test 8: Input was 151");
        }
    }
}
