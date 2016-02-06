using NUnit.Framework;
using Spread.Betting.Providers;
using System;

namespace Spread.Betting.Tests.Providers   
{
    [TestFixture]
    public class GetQuoteFormatterTests
    {
        private GetQuotesFormatProvider _sut;

        [Test]
        public void given_valid_json_return_formatted_result()
        {
            var payload = "{'query':{'count':5,'created':'2016 - 02 - 06T07: 34:09Z','lang':'en - US','results':{'rate':[{'id':'AUDCAD','Name':'AUD / CAD','Rate':'0.9831','Date':'2 / 6 / 2016','Time':'7:33am','Ask':'0.9835','Bid':'0.9826'},{'id':'AUDCHF','Name':'AUD / CHF','Rate':'0.7000','Date':'2 / 6 / 2016','Time':'7:33am','Ask':'0.7005','Bid':'0.6995'},{'id':'AUDJPY','Name':'AUD / JPY','Rate':'82.5322','Date':'2 / 6 / 2016','Time':'7:33am','Ask':'82.5791','Bid':'82.4853'},{'id':'AUDNZD','Name':'AUD / NZD','Rate':'1.0660','Date':'2 / 6 / 2016','Time':'7:33am','Ask':'1.0672','Bid':'1.0649'},{'id':'AUDNZD','Name':'AUD / NZD','Rate':'1.0660','Date':'2 / 6 / 2016','Time':'7:33am','Ask':'1.0672','Bid':'1.0649'}]}}}";

            _sut = new GetQuotesFormatProvider();

            var result = _sut.Format(payload);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Created, Is.EqualTo(DateTime.Parse("2016 - 02 - 06T07: 34:09Z")));
            Assert.That(result.Rates.Count, Is.EqualTo(5));
        }
    }
}
