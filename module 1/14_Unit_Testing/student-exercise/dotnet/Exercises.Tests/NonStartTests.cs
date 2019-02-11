using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        NonStart non = new NonStart();

        [TestMethod]
        
        public void GetPartialStringTest()
        {
        
            Assert.AreEqual("ellohere", non.GetPartialString("Hello", "There"), "Test 1: input \"Hello\", \"There\"");
            Assert.AreEqual("avaode", non.GetPartialString("java", "code"), "Test 1: input \"java\", \"code\"");
            Assert.AreEqual("hotlava", non.GetPartialString("shotl", "java"), "Test 1: input \"shotl\", \"java\"");
        }
    }
}
