using GildedRose.Strategies;

namespace Kata
{
    public abstract class DailyItemUpdater
    {
        protected Item _item;

        protected abstract QualityUpdateStrategy QualityStrategy { get; }
        protected abstract int SellInDecreaseAmount { get; }

        public DailyItemUpdater(Item item)
        {
            _item = item;
        }

        public virtual void UpdateQualityAndSellIn()
        {
            _item.Quality = QualityStrategy.ComputeNewQualityValue(_item.Quality, _item.SellIn);

            _item.SellIn -= SellInDecreaseAmount;
        }
    }
}