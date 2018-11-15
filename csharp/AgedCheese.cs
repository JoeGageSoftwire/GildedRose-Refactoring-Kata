namespace csharp
{
    public class AgedCheese : MyItem
    {
        public override void UpdateQuality()
        {
            IncrementQuality(1);
        }
    }
}