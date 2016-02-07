using System;

namespace Spread.Betting.Model
{
    public class Market
    {
        public string MarketCenter { get; set; }
        public string TimeZone { get; set; }
        public TimeSpan Open { get; set; }
        public TimeSpan Closed { get; set; }
        public bool IsOpen { get; set; }

    }
}
