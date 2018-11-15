using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<MyItem> Items;
        public GildedRose(IList<MyItem> Items)
        {
            this.Items = Items;
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
