using Spread.Betting.Model;
using Spread.Betting.Providers.Interfaces;
using System.Threading.Tasks;
using System.Net;

namespace Spread.Betting.Providers
{
    public class YahooFinanceProvider : IYahooFinanceProvider
    {
        private const string BASE_URL = "https://query.yahooapis.com/v1/public/yql?q=";

        private IHttpProvider _httpProvider;
        private ICurrencyPairProvider _currencyPairProvider;
        private IFormatProvider<Quote> _formatter;

        public YahooFinanceProvider(IHttpProvider httpProvider, ICurrencyPairProvider currencyPairProvider, IFormatProvider<Quote> formatter)
        {
            _httpProvider = httpProvider;
            _currencyPairProvider = currencyPairProvider;
            _formatter = formatter;
        }

        public async Task<Quote> GetQuotes()
        {
            var pairs = _currencyPairProvider.Pairs;
            var query = "select * from yahoo.finance.xchange where pair in ('";

            foreach (var pair in pairs)
                query += pair.Symbol + ",";

            query = query.Substring(0, query.Length - 1);
            query += "')";

            var url = BASE_URL + WebUtility.UrlEncode(query) + "&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

            return await _httpProvider.GetAsync(url, _formatter);
        }
    }
}
