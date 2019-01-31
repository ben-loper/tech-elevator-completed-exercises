using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {

        private Lucky13 lucky = new Lucky13();
        /*
         Given an array of ints, return true if the array contains no 1's and no 3's.
         GetLucky([0, 2, 4]) → true
         GetLucky([1, 2, 3]) → false
         GetLucky([1, 2, 4]) → false
         */
        //public bool GetLucky(int[] nums)

        [TestMethod]
        public void GetLuckTest()
        {

            Assert.AreEqual(true, lucky.GetLucky(new int[] { 0, 2, 4 }), "Test 1: Input  [0, 2, 4]");
            Assert.AreEqual(false, lucky.GetLucky(new int[] { 1, 2, 3 }), "Test 1: Input  [0, 2, 4]");
            Assert.AreEqual(false, lucky.GetLucky(new int[] { 1, 2, 4 }), "Test 1: Input  [0, 2, 4]");
        }
    }
}
