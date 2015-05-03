using SingleResponsibilityPrinciple.RefactoredCode;
using System;

namespace OpenClosedPrinciple.RefactoredCode
{
    public interface ILog
    {
        void LogAlert(string message);
    }

    public class Log
    {
        ILog logger;

        public Log(ILog logger)
        {
            this.logger = logger;
        }

        public void LogAlert(string message)
        {
            logger.LogAlert(message);
        }
    }

    public class ConsoleAlert : ILog
    {

        public void LogAlert(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class EmailAlert : ILog
    {

        public void LogAlert(string message)
        {
            //TODO: Send me the email
        }
    }

    public class SMSAlert : ILog
    {

        public void LogAlert(string message)
        {
            //TODO: Send me the SMS
        }
    }

    public class GoldPriceAlert
    {
        public void ShowLowGoldPriceAlert(GoldMeterEnchanced goldmeter, ILog logger)
        {
            var message = string.Format("Better to buy some gold now: {0:F2}", goldmeter.GoldPrice);
            logger.LogAlert(message);
        }
    }
}