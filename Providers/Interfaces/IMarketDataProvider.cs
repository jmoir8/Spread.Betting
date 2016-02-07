using Spread.Betting.Model;
using System.Collections.Generic;

namespace Spread.Betting.Providers.Interfaces
{
    public interface IMarketDataProvider
    {
        List<CurrencyPair> Pairs { get; }
        Market Market { get; }
    }
}
