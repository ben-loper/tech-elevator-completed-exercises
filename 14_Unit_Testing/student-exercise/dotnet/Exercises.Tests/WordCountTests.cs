using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {

        WordCount test = new WordCount();

        [TestMethod]

        public void GetCount()
        {
            Dictionary<string, int> testDict = new Dictionary<string, int>();

            testDict.Add("ba", 2);
            testDict.Add("black", 1);
            testDict.Add("sheep", 1);

            CollectionAssert.AreEqual(testDict, test.GetCount(new string[] { "ba", "ba", "black", "sheep" }), 
                                    "Test 1: Input \"ba\", \"ba\", \"black\", \"sheep\"");

            testDict.Clear();

            testDict.Add("a", 2);
            testDict.Add("b", 2);
            testDict.Add("c", 1);

            CollectionAssert.AreEqual(testDict, test.GetCount(new string[] { "a", "b", "a", "c", "b" }),
                                    "Test 2: Input \"a\", \"b\", \"a\", \"c\", \"b\"");

            testDict.Clear();

            CollectionAssert.AreEqual(testDict, test.GetCount(new string[0]),
                                    "Test 3: Input empty array");

            testDict.Add("c", 1);
            testDict.Add("b", 1);
            testDict.Add("a", 1);

            CollectionAssert.AreEqual(testDict, test.GetCount(new string[] { "c", "b", "a" }),
                                    "Test 4: \"c\", \"b\", \"a\"");
        }
    }
}
