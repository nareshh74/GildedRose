﻿namespace GildedRose.Console
{
    public class AgedBrie : Item
    {
        public AgedBrie(int sellIn, int quality) : base()
        {
            this.Name = "Aged Brie";
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public override void Update()
        {
            if (this.Quality < 50)
            {
                this.Quality++;
            }

            this.SellIn--;

            if (this.SellIn < 0 && this.Quality < 50)
            {
                this.Quality++;
            }
        }
    }
}