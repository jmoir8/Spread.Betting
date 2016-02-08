using System.Threading.Tasks;
using MongoDB.Bson;

namespace Spread.Betting.Data.Interfaces
{
    public interface IDataCommand
    {
        Task Insert(BsonDocument document, string collectionName);
    }
}
