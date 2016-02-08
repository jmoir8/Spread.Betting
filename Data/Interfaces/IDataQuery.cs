using MongoDB.Bson;

namespace Spread.Betting.Data.Interfaces
{
    public interface IDataQuery
    {
        void Insert(BsonDocument document, string collection);
    }
}
