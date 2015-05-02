using System;

namespace SingleResponsibilityPrinciple.RefactoredCode
{
    public class GoldMeterEnchanced
    {
        public double GoldPrice { get; set; }

        public void ReadGoldPrice()
        {
            // for demo purposes let's consider a random value
            var r = new Random();
            // min price 100 + 365 days :)
            GoldPrice = 100 + r.NextDouble() * 365;
        }
    }
}
