using System;

namespace SingleResponsibilityPrinciple.RefactoredCode
{
    public class GoldPriceAlert
    {
        public void ShowLowGoldPriceAlert(GoldMeterEnchanced goldmeter)
        {
            Console.WriteLine("Better to buy some gold now: {0:F2}", goldmeter.GoldPrice);
        }
    }
}
