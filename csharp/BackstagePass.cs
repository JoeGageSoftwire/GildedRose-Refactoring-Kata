namespace csharp
{
    public class BackstagePass: MyItem
    {
        public override void UpdateQuality()
        {
            if (SellIn < 5)
            {
                IncrementQuality(3);
            }
            else if (SellIn < 10)
            {
                IncrementQuality(2);
            }
            else
            {
                IncrementQuality(1);
            }

            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }
}