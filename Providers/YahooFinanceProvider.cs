using System.Linq;
using Spread.Betting.Model;
using Spread.Betting.Providers.Interfaces;
using System.Threading.Tasks;
using System.Net;

namespace Spread.Betting.Providers
{
    public class YahooFinanceProvider : IYahooFinanceProvider
    {
        private const string BaseUrl = "https://query.yahooapis.com/v1/public/yql?q=";

        private readonly IHttpProvider _httpProvider;
        private readonly IMarketDataProvider _marketDataProvider;
        private readonly IFormatProvider<Quote> _formatter;

        public YahooFinanceProvider(IHttpProvider httpProvider, IMarketDataProvider marketDataProvider, IFormatProvider<Quote> formatter)
        {
            _httpProvider = httpProvider;
            _marketDataProvider = marketDataProvider;
            _formatter = formatter;
        }

        public async Task<Quote> GetQuotes()
        {
            if (!_marketDataProvider.Market.IsOpen) return null;

            var pairs = _marketDataProvider.Pairs;

            var query = pairs.Aggregate("select * from yahoo.finance.xchange where pair in ('", (current, pair) => current + (pair.Symbol + ","));
            query = query.Substring(0, query.Length - 1);
            query += "')";

            var url = BaseUrl + WebUtility.UrlEncode(query) + "&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

            return await _httpProvider.GetAsync(url, _formatter);
        }
    }
}
