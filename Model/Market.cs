using System;

namespace Spread.Betting.Model
{
    public class Market
    {
        public string MarketCenter { get; set; }
        public string TimeZone { get; set; }
        public DateTime Open { get; set; }
        public DateTime Closed { get; set; }
        public bool IsOpen { get; set; }

    }
}
