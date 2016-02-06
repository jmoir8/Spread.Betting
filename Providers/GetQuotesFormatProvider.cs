using Spread.Betting.Providers.Interfaces;
using Newtonsoft.Json.Linq;
using Spread.Betting.Model;
using System;
using System.Collections.Generic;

namespace Spread.Betting.Providers
{
    public class GetQuotesFormatProvider : IFormatProvider<Quote>
    { 
        public Quote Format(string payload)
        {
            Quote response = null;

            dynamic obj = JObject.Parse(payload);

            if (obj != null)
            {
                response = new Quote
                {
                    Created = DateTime.Parse((string)obj.query.created),
                    Rates = new List<Rate>()
        
                };

                foreach(dynamic rate in obj.query.results.rate)
                {
                    response.Rates.Add(new Rate
                    {
                        CurrencyPair = new CurrencyPair
                        {
                            Symbol = rate.id
                        },
                        Ask = rate.Ask,
                        Bid = rate.Bid,
                        Price = rate.Rate

                    });

                }
            }

            return response;
        }
    }
}
