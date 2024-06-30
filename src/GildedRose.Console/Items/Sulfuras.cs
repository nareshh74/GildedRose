﻿namespace GildedRose.Console
{
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
