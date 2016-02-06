using Spread.Betting.Model;
using System.Collections.Generic;

namespace Spread.Betting.Providers.Interfaces
{
    public interface ICurrencyPairProvider
    {
        List<CurrencyPair> Pairs { get; }
    }
}
