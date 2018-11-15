using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        public IList<MyItem> Items { get; private set; }

        public GildedRose()
        {
            Items = new List<MyItem>{
                new MyItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new AgedCheese {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new MyItem {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new LegendaryItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new LegendaryItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new BackstagePass
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new BackstagePass
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new BackstagePass
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
                new ConjuredItem {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
        }

        public void UpdateStock()
        {
            foreach (var item in Items)
            {
                item.UpdateSellIn();
                item.UpdateQuality();
            }
        }
    }
}
