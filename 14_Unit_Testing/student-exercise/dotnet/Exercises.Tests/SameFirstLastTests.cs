using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        SameFirstLast test = new SameFirstLast();
        

        [TestMethod]

        public void IsItTheSameTest()
        {


            Assert.AreEqual(false, test.IsItTheSame(new int[] { 1, 2, 3 }), "Test 1: Input [ 1, 2, 3]");
            Assert.AreEqual(true, test.IsItTheSame(new int[] { 1, 2, 3, 1 }), "Test 2: Input [ 1, 2, 3, 1]");
            Assert.AreEqual(true, test.IsItTheSame(new int[] { 1, 2, 1 }), "Test 3: Input [ 1, 2, 1]");
        }
    }
}