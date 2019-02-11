using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        MaxEnd3 end3 = new MaxEnd3();
        /*
         Given an array of ints length 3, figure out which is larger between the first and last elements 
         in the array, and set all the other elements to be that value. Return the changed array.
         MakeArray([1, 2, 3]) → [3, 3, 3]
         MakeArray([11, 5, 9]) → [11, 11, 11]
         MakeArray([2, 11, 3]) → [3, 3, 3]
         */
        //public int[] MakeArray(int[] nums)

        [TestMethod]
        public void MakeArrayTest()
        {
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, end3.MakeArray(new int[] { 1, 2, 3 }), "Test 1: Input [1,2,3]");
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, end3.MakeArray(new int[] { 11, 5, 9 }), "Test 2: Input [11, 5, 9]");
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, end3.MakeArray(new int[] { 2, 11, 3 }), "Test 3: Input [2, 11, 3]");
        }
    }
}
