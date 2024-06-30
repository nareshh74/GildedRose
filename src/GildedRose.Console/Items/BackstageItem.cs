namespace GildedRose.Console
{
    public class BackstageItem : Item
    {
        public BackstageItem(int sellIn, int quality) : base()
        {
            this.Name = "Backstage passes to a TAFKAL80ETC concert";
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public override void Update()
        {
            if (this.Quality < 50)
            {
                this.Quality = this.Quality + 1;

                if (this.SellIn < 11)
                {
                    if (this.Quality < 50)
                    {
                        this.Quality = this.Quality + 1;
                    }
                }

                if (this.SellIn < 6)
                {
                    if (this.Quality < 50)
                    {
                        this.Quality = this.Quality + 1;
                    }
                }
            }

            this.DecreaseSellIn();

            if (this.SellIn < 0)
            {
                this.Quality = this.Quality - this.Quality;
            }
        }
    }
}
