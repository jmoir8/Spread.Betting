using System.Threading.Tasks;
using MongoDB.Bson;
using Spread.Betting.Data.Interfaces;

namespace Spread.Betting.Data
{
    public class DataCommand : IDataCommand
    {
        private readonly IDataContext _dataContext;

        public DataCommand(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Insert(BsonDocument document, string collectionName)
        {
            var collection = _dataContext.Database.GetCollection<BsonDocument>(collectionName);
            await collection.InsertOneAsync(document);
        }
    }
}
