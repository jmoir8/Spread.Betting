using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Spread.Betting.Providers.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Spread.Betting.Providers
{
    public class HttpProvider : IHttpProvider
    {
        public async Task<T> GetAsync<T>(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                return await ReadAsAsync<T>(response);
            }
        }

        public async Task<T> GetAsync<T>(string url, IFormatProvider<T> formatter)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                return await ReadAsAsync<T>(response, formatter);
            }
        }

        private async Task<T> ReadAsAsync<T>(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode) throw new Exception(string.Concat(response.StatusCode, ":", response.ReasonPhrase));
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        private async Task<T> ReadAsAsync<T>(HttpResponseMessage response, IFormatProvider<T> formatter)
        {
            if (!response.IsSuccessStatusCode) throw new Exception(string.Concat(response.StatusCode, ":", response.ReasonPhrase));
            var content = await response.Content.ReadAsStringAsync();
            return formatter.Format(content);
        }
    }
}
