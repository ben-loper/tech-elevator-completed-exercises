using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass]
    public class KataPotterTests
    {
        KataPotter kata = new KataPotter();

        // Buy a single book, no discount
        [TestMethod]
        public void BuyOneBook()
        {
            Assert.AreEqual(8m, kata.GetCost(new int[] { 1 }), "Purchase a single book");
        }

        // Buy multiples of the same books, no discount
        [TestMethod]
        public void MultipleBooksOfSameType()
        {
            Assert.AreEqual(16, kata.GetCost(new int[] { 2 }), 
                "Purchase 2 of the same book");

            Assert.AreEqual(40, kata.GetCost(new int[] { 5, 0, 0 }), 
                "Purchase 5 of the same book");

            Assert.AreEqual(32, kata.GetCost(new int[] { 0, 0, 0, 0, 4 }),
                "Purchase 4 of the same book");

            Assert.AreEqual(24, kata.GetCost(new int[] { 0, 0, 3, 0, 0 }),
                "Purchase 4 of the same book");
        }

        // Buy 2 different books from the series, get a 5% discount on those two books
        [TestMethod]
        public void BuyTwoBooksFivePercentDiscount()
        {
            Assert.AreEqual(15.2m, kata.GetCost(new int[] { 1, 1 }),
                "Purchase 2 different books in the series");
        }

        // Buy 3 different books from the series, get a 10% discount on those three books
        [TestMethod]
        public void BuyThreeBooksTenPercentDiscount()
        {
            Assert.AreEqual(21.6m, kata.GetCost(new int[] { 1, 1, 1 }),
                "Purchase 3 different books in the series");
        }
        
        // Buy 4 different books from the series, get a 20% discount on those four books
        [TestMethod]
        public void BuyFourBooksTwentyPercentDiscount()
        {
            Assert.AreEqual(25.6m, kata.GetCost(new int[] { 1, 1, 1, 1 }),
                "Purchase 4 different books in the series");
        }

        // Buy 5 different books from the series, get a 25% discount on those five books
        [TestMethod]
        public void BuyFiveBooksTwentyFivePercentDiscount()
        {
            Assert.AreEqual(30m, kata.GetCost(new int[] { 1, 1, 1, 1, 1 }),
                "Purchase 5 different books in the series");
        }

        [TestMethod]
        public void GivenScenario()
        {
            Assert.AreEqual(51.20m, kata.GetCost(new int[] { 2, 2, 2, 1, 1 }),
                "Purchase 5 different books in the series");
        }
    }
}
