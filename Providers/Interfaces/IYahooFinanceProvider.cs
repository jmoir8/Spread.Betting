using Spread.Betting.Model;
using System.Threading.Tasks;

namespace Spread.Betting.Providers.Interfaces
{
    public interface IYahooFinanceProvider
    {
        Task<Quote> GetQuotes();
    }
}
