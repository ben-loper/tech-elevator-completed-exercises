using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        private AnimalGroupName animalGroup = new AnimalGroupName();
        /*
        * Given the name of an animal, return the name of a group of that animal
        * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").  
        * 
        * The animal name should be case insensitive so "elephant", "Elephant", and 
        * "ELEPHANT" should all return "herd". 
        * 
        * If the name of the animal is not found, null, or empty, return "unknown". 
        * 
        * Rhino -> Crash
        * Giraffe -> Tower
        * Elephant -> Herd
        * Lion -> Pride
        * Crow -> Murder
        * Pigeon -> Kit
        * Flamingo -> Pat
        * Deer -> Herd
        * Dog -> Pack
        * Crocodile -> Float
        *
        * GetHerd("giraffe") → "Tower"
        * GetHerd("") -> "unknown"         
        * GetHerd("walrus") -> "unknown"
        * GetHerd("Rhino") -> "Crash"
        * GetHerd("rhino") -> "Crash"
        * GetHerd("elephants") -> "unknown"
        * 
        */

        /*    
                {"rhino", "Crash" },
                {"giraffe", "Tower" },
                {"elephant", "Herd" },
                {"lion", "Pride" },
                {"crow", "Murder" },
                {"pigeon", "Kit" },
                {"flamingo", "Pat" },
                {"deer", "Herd" },
                {"dog", "Pack" },
                {"crocodile", "Float" },
*/
        [TestMethod]
        public void GetHerdTest()
        {
            Assert.AreEqual("Tower", animalGroup.GetHerd("giraffe"), "Test 1: Input was \"giraffe\"");
            Assert.AreEqual("unknown", animalGroup.GetHerd(""), "Test 2: Input was \"\"");
            Assert.AreEqual("unknown", animalGroup.GetHerd("walrus"), "Test 3: Input was \"walrus\"");
            Assert.AreEqual("Crash", animalGroup.GetHerd("Rhino"), "Test 4: Input was \"Rhino\"");
            Assert.AreEqual("Crash", animalGroup.GetHerd("rhino"), "Test 5: Input was \"rhino\"");
            Assert.AreEqual("Pride", animalGroup.GetHerd("lion"), "Test 6: Input was \"lion\"");
            Assert.AreEqual("Murder", animalGroup.GetHerd("crow"), "Test 7: Input was \"crow\"");
            Assert.AreEqual("Kit", animalGroup.GetHerd("pigeon"), "Test 8: Input was \"pidgeon\"");
            Assert.AreEqual("Pat", animalGroup.GetHerd("flamingo"), "Test 9: Input was \"flamingo\"");
            Assert.AreEqual("Herd", animalGroup.GetHerd("deer"), "Test 10: Input was \"deer\"");
            Assert.AreEqual("Pack", animalGroup.GetHerd("dog"), "Test 11: Input was \"dog\"");
            Assert.AreEqual("Float", animalGroup.GetHerd("crocodile"), "Test 12: Input was \"crocodile\"");
            

        }
    }
}
