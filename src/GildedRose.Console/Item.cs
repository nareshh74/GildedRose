namespace GildedRose.Console
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public virtual void Update()
        {
            if (this.Quality > 0)
            {
                this.Quality = this.Quality - 1;
            }

            this.SellIn = this.SellIn - 1;

            if (this.SellIn < 0)
            {
                if (this.Quality > 0)
                {
                    this.Quality = this.Quality - 1;
                }
            }
        }
    }

    public class Sulfuras : Item
    {
        public Sulfuras(int sellIn, int quality) : base()
        {
            this.Name = "Sulfuras, Hand of Ragnaros";
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public override void Update()
        {
            // Sulfuras never has to be sold or decreases in Quality
        }
    }
}
