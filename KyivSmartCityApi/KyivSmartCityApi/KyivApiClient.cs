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

        public async Task<ListDocuments> GetDocumentsAsync()
        {
            var res = JsonConvert.DeserializeObject<ListDocuments>(await client.GetAsync("api/user/documents").Result.Content.ReadAsStringAsync());
            return res;
        }

        public async Task<List<Feed>> GetFeedsAsync()
        {
            var res = JsonConvert.DeserializeObject<Result>(await client.GetAsync("api/feed").Result.Content.ReadAsStringAsync());
            return res.Feed;
        }

        public async Task<FeedItem> GetFeedAsync(string Id)
        {
            var content = await client.GetAsync($"api/feed/{Id}").Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FeedItem>(content);
        }

        public async Task<TravelCards> GetTravelCardsAsync()
        {
            return JsonConvert.DeserializeObject<TravelCards>(await client.GetAsync("api/card/travel").Result.Content.ReadAsStringAsync());
        }

        public async Task<List<Trip>> GetTravelCardHistoryAsync(int Id)
        {
            var res = JsonConvert.DeserializeObject<Result>(await client.GetAsync($"api/card/travel/{Id}/history").Result.Content.ReadAsStringAsync());
            return res.Trips;
        }

        public async Task<SmartCardInfo> GetSmartCardInfoAsync(int Id)
        {
            var res = JsonConvert.DeserializeObject<SmartCardInfo>(await client.GetAsync($"api/card/travel/{Id}/feed").Result.Content.ReadAsStringAsync());
            return res;
        }
    }
}