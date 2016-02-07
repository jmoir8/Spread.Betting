using Microsoft.Practices.Unity;
using Spread.Betting.Model;
using Spread.Betting.Providers.Interfaces;

namespace Spread.Betting.Providers
{
    public class ProvidersModule : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IHttpProvider, HttpProvider>();
            Container.RegisterType<IFormatProvider<Quote>, GetQuotesFormatProvider>();
            Container.RegisterType<IMarketDataProvider, MarketDataProvider>();
            Container.RegisterType<IYahooFinanceProvider, YahooFinanceProvider>();
        }
    }
}
