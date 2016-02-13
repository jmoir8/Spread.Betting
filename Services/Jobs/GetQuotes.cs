using Quartz;
using Spread.Betting.Providers.Interfaces;
using Spread.Betting.Services.Interfaces;
using System;
using Spread.Betting.Data.Interfaces;

namespace Spread.Betting.Services.Jobs
{
    [DisallowConcurrentExecution]
    public class GetQuotes : IJob
    {
        private readonly IYahooFinanceProvider _provider;
        private readonly ILogger _logger;
        private readonly IDataRepository _repository;

        public GetQuotes(IYahooFinanceProvider provider, ILogger logger, IDataRepository repository)
        {
            _provider = provider;
            _logger = logger;
            _repository = repository;
        }

        public async void Execute(IJobExecutionContext context)
        {
            try
            {
                var quote = await _provider.GetQuote();

                if (quote != null)
                    _repository.Quotes.InsertOne(quote);
            }
            catch (Exception ex)
            {
                _logger.Error("The get quotes job failed to process.  Error: " + ex.Message);
                throw ex;
            }

            
        }
    }
}
