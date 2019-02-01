using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        StringBits test = new StringBits();

        [TestMethod]

        public void GetBitsTest()
        {

            Assert.AreEqual("Hlo", test.GetBits("Hello"), "Test 1: Input \"Hello\"");
            Assert.AreEqual("H", test.GetBits("Hi"), "Test 2: Input \"Hi\"");
            Assert.AreEqual("Hello", test.GetBits("Heeololeo"), "Test 3: Input \"Heeololeo\"");
        }
    }
}
