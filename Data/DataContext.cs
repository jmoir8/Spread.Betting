using MongoDB.Driver;
using Spread.Betting.Data.Interfaces;

namespace Spread.Betting.Data
{
    public class DataContext : IDataContext
    {
        protected static IMongoClient Client;

        public DataContext()
        {
            Client = new MongoClient();
            Database = Client.GetDatabase("test");
        }

        public IMongoDatabase Database { get; set; }
    }
}
