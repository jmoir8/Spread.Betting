using MongoDB.Bson.Serialization.Attributes;

namespace Spread.Betting.Model
{
    public class Rate
    {
        public CurrencyPair CurrencyPair { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public decimal Price { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public decimal Bid { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public decimal Ask { get; set; }
    }
}
