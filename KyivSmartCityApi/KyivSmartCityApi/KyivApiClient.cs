using KyivSmartCityApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KyivSmartCityApi
{
    public class KyivApiClient
    {
        private const string KyivApiUrl = "https://app.kyivcity.gov.ua";
        private string accessToken;
        private HttpClient client;
        public KyivApiClient(string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException($"{nameof(accessToken)} is null");
            this.accessToken = accessToken;
            client = new HttpClient();
            client.BaseAddress = new Uri(KyivApiUrl);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        }

        public async Task<List<Feed>> GetFeeds()
        {
            var res = JsonConvert.DeserializeObject<Result>(await client.GetAsync("api/feed").Result.Content.ReadAsStringAsync());
            return res.Feed;
        }
    }
}