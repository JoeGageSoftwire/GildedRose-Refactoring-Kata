namespace csharp
{
    public class ConjuredItem : MyItem
    {
        public override void UpdateQuality()
        {
            IncrementQuality(-2);
        }
    }
}