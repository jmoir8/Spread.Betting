using System.Threading;
using System.Threading.Tasks;
using MongoDB.Driver;
using Moq;
using NUnit.Framework;
using Quartz;
using Spread.Betting.Data.Interfaces;
using Spread.Betting.Providers.Interfaces;
using Spread.Betting.Services.Interfaces;
using Spread.Betting.Services.Jobs;
using Spread.Betting.Model;

namespace Spread.Betting.Tests.Services
{
    [TestFixture]
    public class GetQuoteTests
    {
        private GetQuotes _sut;
        private Mock<ILogger> _log;
        private Mock<IYahooFinanceProvider> _provider;
        private Mock<IJobExecutionContext> _context;
        private Mock<IDataRepository> _dataRepository;
        private Mock<IMongoCollection<Quote>> _collection;

        [SetUp]
        public void SetUp()
        {
            _log = new Mock<ILogger>();
            _provider = new Mock<IYahooFinanceProvider>();
            _context = new Mock<IJobExecutionContext>();
            _dataRepository = new Mock<IDataRepository>();
            _collection = new Mock<IMongoCollection<Quote>>();
        }

        [Test]
        public void given_valid_request_process_test_successfully()
        {
            var quote = new Quote();

            _dataRepository.SetupGet(x => x.Quotes).Returns(_collection.Object);

            _provider.Setup(x => x.GetQuote()).Returns(Task.FromResult(quote));

            _sut = new GetQuotes(_provider.Object, _log.Object, _dataRepository.Object);

            _sut.Execute(_context.Object);

            _collection.Verify(x => x.InsertOne(quote, null, CancellationToken.None));
        }
    }
}
