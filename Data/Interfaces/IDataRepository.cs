using MongoDB.Driver;
using Spread.Betting.Model;

namespace Spread.Betting.Data.Interfaces
{
    public interface IDataRepository
    {
        IMongoCollection<Quote> Quotes { get; }
        IMongoCollection<Rate> Rates { get; }
    }
}
