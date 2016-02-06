namespace Spread.Betting.Model
{
    public class Rate
    {
        public CurrencyPair CurrencyPair { get; set; }
        public decimal Price { get; set; }
        public decimal Bid { get; set; }
        public decimal Ask { get; set; }
    }
}
