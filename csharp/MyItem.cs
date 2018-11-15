namespace csharp
{
    public class MyItem : Item
    {
        public virtual void UpdateSellIn()
        {
            --SellIn;
        }

        public virtual void UpdateQuality()
        {
            IncrementQuality(-1);
        }

        public void IncrementQuality(int i)
        {
            Quality = SellIn >= 0 ? Quality + i : Quality + 2*i;
            Quality = Quality < 0 ? 0 : Quality;
            Quality = Quality > 50 ? 50 : Quality;
        }
    }
}