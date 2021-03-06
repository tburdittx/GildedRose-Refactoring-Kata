﻿using System;
using System.Collections;
using System.Collections.Generic;
using csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgedBrieQualityWithSellInDate()
        {
            //arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(Items);

          //  var Quality = new quality();

           
            //act
            app.UpdateQuality();
            //assert
            Assert.AreEqual(6, Items[0].Quality);
        }
    }
}
