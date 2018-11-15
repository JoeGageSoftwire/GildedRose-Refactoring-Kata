using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<MyItem> Items = new List<MyItem> { new MyItem { Name = "fixme", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateStock();
            Assert.AreEqual("fixme", Items[0].Name);
        }
    }
}
