using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void ItemName()

        {
            //arrange- set up the conditions for the test
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
                      
            GildedRose app = new GildedRose(Items);

            // act- where the running of the test happens
            app.UpdateQuality();

            //assert- where you get the results
            Assert.AreEqual("foo", Items[0].Name);
        }
    }
}
