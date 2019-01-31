using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        private AnimalGroupName animalGroup = new AnimalGroupName();

        [TestMethod]
        public void GetHerdTest()
        {
            Assert.AreEqual("Tower", animalGroup.GetHerd("giraffe"), "Test 1: Input was \"giraffe\"");
            Assert.AreEqual("unknown", animalGroup.GetHerd(""), "Test 2: Input was \"\"");
            Assert.AreEqual("unknown", animalGroup.GetHerd("walrus"), "Test 3: Input was \"walrus\"");
            Assert.AreEqual("Crash", animalGroup.GetHerd("Rhino"), "Test 4: Input was \"Rhino\"");
            Assert.AreEqual("Crash", animalGroup.GetHerd("rhino"), "Test 5: Input was \"rhino\"");
            Assert.AreEqual("unknown", animalGroup.GetHerd("elephants"), "Test 6: Input was \"elephants\"");
        }
    }
}
