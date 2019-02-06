using FizzWriter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void DivisibleByThree()
        {
            Assert.AreEqual("Fizz", FizzBuzz.FizzBuzzBuilder(3), "Test Value: 3");
            Assert.AreEqual("Fizz", FizzBuzz.FizzBuzzBuilder(6), "Test Value: 6");
        }

        [TestMethod]
        public void DivisibleByFive()
        {
            Assert.AreEqual("Buzz", FizzBuzz.FizzBuzzBuilder(5), "Test Value: 5");
            Assert.AreEqual("Buzz", FizzBuzz.FizzBuzzBuilder(20), "Test Value: 20");
        }

        [TestMethod]
        public void DivisibleByFiveAndThree()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.FizzBuzzBuilder(15), "Test Value: 15");
            Assert.AreEqual("FizzBuzz", FizzBuzz.FizzBuzzBuilder(30), "Test Value: 30");
        }
    }
}
