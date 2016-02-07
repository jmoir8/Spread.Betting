using System;
using System.Collections.Generic;
using Spread.Betting.Model;
using Spread.Betting.Providers.Interfaces;

namespace Spread.Betting.Providers
{
    public class MarketDataProvider : IMarketDataProvider
    {
        private List<CurrencyPair> _pairs;
        private List<Market> _market;

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

        public List<Market> Market
        {
            get
            {
                return _market;
            }
        }

        private void GetPairs()
        {
            _pairs = new List<CurrencyPair>();

            // Australian Dollar
            _pairs.Add(new CurrencyPair { Symbol = "AUDCAD" });
            _pairs.Add(new CurrencyPair { Symbol = "AUDCHF" });
            _pairs.Add(new CurrencyPair { Symbol = "AUDJPY" });
            _pairs.Add(new CurrencyPair { Symbol = "AUDNZD" });
            _pairs.Add(new CurrencyPair { Symbol = "AUDNZD" });
            //Candadian Dollar
            _pairs.Add(new CurrencyPair { Symbol = "CADCHF" });
            _pairs.Add(new CurrencyPair { Symbol = "CADJPY" });
            // Swiss Franc
            _pairs.Add(new CurrencyPair { Symbol = "CHFJPY" });
            //Euro
            _pairs.Add(new CurrencyPair { Symbol = "EURAUD" });
            _pairs.Add(new CurrencyPair { Symbol = "EURCAD" });
            _pairs.Add(new CurrencyPair { Symbol = "EURCHF" });
            _pairs.Add(new CurrencyPair { Symbol = "EURDKK" });
            _pairs.Add(new CurrencyPair { Symbol = "EURGBP" });
            _pairs.Add(new CurrencyPair { Symbol = "EURDKK" });
            _pairs.Add(new CurrencyPair { Symbol = "EURGBP" });
            _pairs.Add(new CurrencyPair { Symbol = "EURHUF" });
            _pairs.Add(new CurrencyPair { Symbol = "EURJPY" });
            _pairs.Add(new CurrencyPair { Symbol = "EURNZD" });
            _pairs.Add(new CurrencyPair { Symbol = "EURPLN" });
            _pairs.Add(new CurrencyPair { Symbol = "EURUSD" });
            // Sterling
            _pairs.Add(new CurrencyPair { Symbol = "GBPAUD" });
            _pairs.Add(new CurrencyPair { Symbol = "GBPCAD" });
            _pairs.Add(new CurrencyPair { Symbol = "GBPCHF" });
            _pairs.Add(new CurrencyPair { Symbol = "GBPJPY" });
            _pairs.Add(new CurrencyPair { Symbol = "GBPNZD" });
            _pairs.Add(new CurrencyPair { Symbol = "GBPUSD" });
            // New Zealand Dollar
            _pairs.Add(new CurrencyPair { Symbol = "NZDCAD" });
            _pairs.Add(new CurrencyPair { Symbol = "NZDCHF" });
            _pairs.Add(new CurrencyPair { Symbol = "NZDJPY" });
            _pairs.Add(new CurrencyPair { Symbol = "NZDUSD" });
            // US Dollar
            _pairs.Add(new CurrencyPair { Symbol = "USDCAD" });
            _pairs.Add(new CurrencyPair { Symbol = "USDCHF" });
            _pairs.Add(new CurrencyPair { Symbol = "USDDKK" });
            _pairs.Add(new CurrencyPair { Symbol = "USDHKD" });
            _pairs.Add(new CurrencyPair { Symbol = "USDHKD" });
            _pairs.Add(new CurrencyPair { Symbol = "USDHUF" });
            _pairs.Add(new CurrencyPair { Symbol = "USDJPY" });
            _pairs.Add(new CurrencyPair { Symbol = "USDNOK" });
            _pairs.Add(new CurrencyPair { Symbol = "USDPLN" });
            _pairs.Add(new CurrencyPair { Symbol = "USDRON" });
            _pairs.Add(new CurrencyPair { Symbol = "USDSEK" });
            _pairs.Add(new CurrencyPair { Symbol = "USDSGD" });
            _pairs.Add(new CurrencyPair { Symbol = "USDTRY" });
            _pairs.Add(new CurrencyPair { Symbol = "USDZAR" });
            // South African Rand
            _pairs.Add(new CurrencyPair { Symbol = "ZARJPY" });
        }

        private void GetMarket()
        {
            _market = new List<Market>();
            _market.Add(new Market
            {
                MarketCenter = "London",
                TimeZone = "GMT Standard Time",
                Open = new TimeSpan(8, 0, 0),
                Closed = new TimeSpan(16, 0, 0)
            });

        }
    }
}
