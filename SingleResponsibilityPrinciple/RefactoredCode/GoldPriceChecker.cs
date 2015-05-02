
namespace SingleResponsibilityPrinciple.RefactoredCode
{
    public class GoldPriceChecker
    {
        private double myMaxGoldPrice = 120;
        public bool IsGoldPriceLow(GoldMeterEnchanced goldmeter)
        {
            return goldmeter.GoldPrice <= myMaxGoldPrice;
        }
    }
}
