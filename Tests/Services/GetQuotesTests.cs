using Moq;
using NUnit.Framework;
using Quartz;
using Spread.Betting.Providers.Interfaces;
using Spread.Betting.Services.Interfaces;
using Spread.Betting.Services.Jobs;

namespace Spread.Betting.Tests.Services
{
    [TestFixture]
    public class GetQuotesTests
    {
        private GetQuotes _sut;
        private Mock<ILogger> _log;
        private Mock<IYahooFinanceProvider> _provider;
        private Mock<IJobExecutionContext> _context;

        [SetUp]
        public void SetUp()
        {
            _log = new Mock<ILogger>();
            _provider = new Mock<IYahooFinanceProvider>();
            _context = new Mock<IJobExecutionContext>();
        }

        [Test]
        public void given_valid_request_process_test_successfully()
        {
            _sut = new GetQuotes(_provider.Object, _log.Object);

            _sut.Execute(_context.Object);

            _provider.Verify(x => x.GetQuotes());
        }
    }
}
