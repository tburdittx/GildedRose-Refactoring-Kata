using System;
using System.Collections.Generic;
using csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void QualityDoesntGoOver50()
        {
            //Quality stops when it gets to 50

            //arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 } };
            GildedRose app = new GildedRose(Items);

            //  var Quality = new quality();


            //act
            app.UpdateQuality();
            //assert
            Assert.AreEqual(50, Items[0].Quality);
        }
    }
}
