using System;
using System.Collections.Generic;

namespace Spread.Betting.Model
{
    public class Quote
    {
        public DateTime Created { get; set; }
        public List<Rate> Rates { get; set; }
    }
}
