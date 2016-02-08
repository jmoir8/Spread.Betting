using MongoDB.Driver;

namespace Spread.Betting.Data.Interfaces
{
    public interface IDataContext
    {
        IMongoDatabase Database { get; set; }
    }
}
