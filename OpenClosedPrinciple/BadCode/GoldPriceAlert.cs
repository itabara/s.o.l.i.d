using SingleResponsibilityPrinciple.RefactoredCode;
using System;

namespace OpenClosedPrinciple.BadCode
{
    public class GoldPriceAlert
    {
        public void ShowLowGoldPriceAlert(GoldMeterEnchanced goldmeter, LogType logType)
        {
            if (logType == LogType.Email)
            {
                // TODO: Send me the email
                return;
            }

            Console.WriteLine("Better to buy some gold now: {0:F2}", goldmeter.GoldPrice);
        }
    }

    public enum LogType
    {
        Console,
        Email,
        SMS
    }
}
