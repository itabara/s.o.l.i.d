using System;

namespace SingleResponsibilityPrinciple.BadCode
{
    public class GoldMeter
    {
        public double GoldPrice { get; set; }

        public void ReadGoldPrice()
        {
            // for demo purposes let's consider a random value
            var r = new Random();
            // min price 100 + 365 days :)
            GoldPrice = 100 + r.NextDouble() * 365;
        }

        public bool IsGoldPriceLow()
        {
            return GoldPrice <= 120;
        }

        public void ShowLowGoldPriceAlert()
        {
            Console.WriteLine("Better to buy some gold now: {0:F2}", GoldPrice);
        }
    }
}
