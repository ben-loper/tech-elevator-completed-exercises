using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        private CigarParty cigarTest = new CigarParty();

        [TestMethod]
        public void HavePartyTest()
        {
            Assert.AreEqual(false, cigarTest.HaveParty(30, false), "Test 1: 30 cigars and is not the weekend");
            Assert.AreEqual(true, cigarTest.HaveParty(50, true), "Test 2: 50 cigars and is the weekend");
            Assert.AreEqual(true, cigarTest.HaveParty(70, true), "Test 3: 70 cigars and is the weekend");
        }

    }
}
