using Quartz;
using Spread.Betting.Providers.Interfaces;
using Spread.Betting.Services.Interfaces;
using System;

namespace Spread.Betting.Services.Jobs
{
    [DisallowConcurrentExecution]
    public class GetQuotes : IJob
    {
        private readonly IYahooFinanceProvider _provider;
        private readonly ILogger _logger;

        public GetQuotes(IYahooFinanceProvider provider, ILogger logger)
        {
            _provider = provider;
            _logger = logger;
        }

        public async void Execute(IJobExecutionContext context)
        {
            try
            {
                var quotes = await _provider.GetQuotes();
            }
            catch (Exception ex)
            {
                _logger.Error("The get quotes job failed to process.  Error: " + ex.Message);
                throw ex;
            }

            
        }
    }
}
