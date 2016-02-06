using System;
using System.Threading.Tasks;

namespace Spread.Betting.Providers.Interfaces
{
    public interface IHttpProvider
    {
        Task<T> GetAsync<T>(string url);
        Task<T> GetAsync<T>(string url, IFormatProvider<T> formatter);
    }
}
