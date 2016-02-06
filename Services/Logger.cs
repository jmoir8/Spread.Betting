using System.Reflection;
using log4net;
using log4net.Config;
using Spread.Betting.Services.Interfaces;

namespace Spread.Betting.Services
{
    public class Logger : ILogger
    {
        private readonly ILog _logger;

        public Logger()
        {
            XmlConfigurator.Configure();
            _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }
    }
}
