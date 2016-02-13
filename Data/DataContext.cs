using MongoDB.Driver;
using Spread.Betting.Data.Interfaces;

namespace Spread.Betting.Data
{
    public class DataContext : IDataContext
    {
        protected static IMongoClient Client;

        public DataContext()
        {
            if (Client == null)
                Client = new MongoClient();
            Database = Client.GetDatabase("SpreadBetting");
        }

        public IMongoDatabase Database { get; set; }
    }
}
