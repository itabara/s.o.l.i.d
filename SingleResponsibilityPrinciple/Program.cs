using SingleResponsibilityPrinciple.BadCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            GoldMeter gold1 = new GoldMeter();
            gold1.ReadGoldPrice();
            gold1.ShowLowGoldPriceAlert();
        }
    }
}
