using System;
using System.Collections.Generic;
using Spread.Betting.Model;
using Spread.Betting.Providers.Interfaces;

namespace Spread.Betting.Providers
{
    public class MarketDataProvider : IMarketDataProvider
    {
        private List<CurrencyPair> _pairs;
        private Market _market;

        public MarketDataProvider()
        {
            GetPairs();
            GetMarket();
        }

        public List<CurrencyPair> Pairs
        {
            get
            {
                return _pairs;
            }
        }

        public Market Market
        {
            get
            {
                var localDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById(_market.TimeZone));
                var localTime = new TimeSpan(localDateTime.Hour, localDateTime.Minute, localDateTime.Second);
                _market.IsOpen = localTime >=_market.Open && localTime <=_market.Closed;
                return _market;
            }
        }

        private void GetPairs()
        {
            _pairs = new List<CurrencyPair>
            {
                new CurrencyPair {Symbol = "AUDCAD"},
                new CurrencyPair {Symbol = "AUDCHF"},
                new CurrencyPair {Symbol = "AUDJPY"},
                new CurrencyPair {Symbol = "AUDNZD"},
                new CurrencyPair {Symbol = "AUDNZD"},
                new CurrencyPair {Symbol = "CADCHF"},
                new CurrencyPair {Symbol = "CADJPY"},
                new CurrencyPair {Symbol = "CHFJPY"},
                new CurrencyPair {Symbol = "EURAUD"},
                new CurrencyPair {Symbol = "EURCAD"},
                new CurrencyPair {Symbol = "EURCHF"},
                new CurrencyPair {Symbol = "EURDKK"},
                new CurrencyPair {Symbol = "EURGBP"},
                new CurrencyPair {Symbol = "EURDKK"},
                new CurrencyPair {Symbol = "EURGBP"},
                new CurrencyPair {Symbol = "EURHUF"},
                new CurrencyPair {Symbol = "EURJPY"},
                new CurrencyPair {Symbol = "EURNZD"},
                new CurrencyPair {Symbol = "EURPLN"},
                new CurrencyPair {Symbol = "EURUSD"},
                new CurrencyPair {Symbol = "GBPAUD"},
                new CurrencyPair {Symbol = "GBPCAD"},
                new CurrencyPair {Symbol = "GBPCHF"},
                new CurrencyPair {Symbol = "GBPJPY"},
                new CurrencyPair {Symbol = "GBPNZD"},
                new CurrencyPair {Symbol = "GBPUSD"},
                new CurrencyPair {Symbol = "NZDCAD"},
                new CurrencyPair {Symbol = "NZDCHF"},
                new CurrencyPair {Symbol = "NZDJPY"},
                new CurrencyPair {Symbol = "NZDUSD"},
                new CurrencyPair {Symbol = "USDCAD"},
                new CurrencyPair {Symbol = "USDCHF"},
                new CurrencyPair {Symbol = "USDDKK"},
                new CurrencyPair {Symbol = "USDHKD"},
                new CurrencyPair {Symbol = "USDHKD"},
                new CurrencyPair {Symbol = "USDHUF"},
                new CurrencyPair {Symbol = "USDJPY"},
                new CurrencyPair {Symbol = "USDNOK"},
                new CurrencyPair {Symbol = "USDPLN"},
                new CurrencyPair {Symbol = "USDRON"},
                new CurrencyPair {Symbol = "USDSEK"},
                new CurrencyPair {Symbol = "USDSGD"},
                new CurrencyPair {Symbol = "USDTRY"},
                new CurrencyPair {Symbol = "USDZAR"},
                new CurrencyPair {Symbol = "ZARJPY"}
            };

            // Australian Dollar
            // Candadian Dollar
            // Swiss Franc
            // Euro
            // Sterling
            // New Zealand Dollar
            // US Dollar
            // South African Rand
        }

        private void GetMarket()
        {
            _market = new Market
            {
                MarketCenter = "London",
                TimeZone = "GMT Standard Time",
                Open = new TimeSpan(8, 0, 0),
                Closed = new TimeSpan(16, 0, 0)
            };

        }
    }
}
