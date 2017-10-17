using System;
using System.Collections.Generic;
using csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgedBrieNoSellInDate()
        {
            //Should increase by 2 if there is no SellIn Date

            //arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);

            //  var Quality = new quality();


            //act
            app.UpdateQuality();
            //assert
            Assert.AreEqual(7, Items[0].Quality);
        }
    }
}
