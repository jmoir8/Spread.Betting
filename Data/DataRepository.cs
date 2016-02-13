using MongoDB.Driver;
using Spread.Betting.Data.Interfaces;
using Spread.Betting.Model;

namespace Spread.Betting.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly IMongoDatabase _dataContext;

        public DataRepository(IDataContext dataContext)
        {
            _dataContext = dataContext.Database;
        }

        public IMongoCollection<Quote> Quotes
        {
            get
            {
                return _dataContext.GetCollection<Quote>("quotes");
            }
        }

        public IMongoCollection<Rate> Rates
        {
            get
            {
                return _dataContext.GetCollection<Rate>("rates");
            }
        }
    }
}
