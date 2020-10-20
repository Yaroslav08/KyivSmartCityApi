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


        public async Task<SmartCard> AddSmartCard(CreateSmartCardModel model)
        {
            var json = JsonConvert.SerializeObject(model);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var res = await client.PostAsync("api/card/travel/add", data).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SmartCard>(res);
        }

        public async Task<User> GetUserAsync()
        {
            return JsonConvert.DeserializeObject<User>(await client.GetStringAsync("api/user/profile"));
        }

        public async Task<ListDocuments> GetDocumentsAsync()
        {
            return JsonConvert.DeserializeObject<ListDocuments>(await client.GetStringAsync("api/user/documents"));
        }

        public async Task<Document> GetDocumentAsync(int Id)
        {
            return JsonConvert.DeserializeObject<Document>(await client.GetStringAsync($"api/user/documents/{Id}"));
        }

        public async Task<ListBankCards> GetBankCardsAsync()
        {
            return JsonConvert.DeserializeObject<ListBankCards>(await client.GetStringAsync("api/card/bank"));
        }

        public async Task<ResponseBase> RemoveBankCardAsync(int Id)
        {
            return JsonConvert.DeserializeObject<ResponseBase>(await client.DeleteAsync($"api/card/bank/{Id}").Result.Content.ReadAsStringAsync());
        }

        public async Task<ListAddresses> GetAddressesAsync()
        {
            return JsonConvert.DeserializeObject<ListAddresses>(await client.GetStringAsync("api/user/addresses"));
        }

        public async Task<List<Feed>> GetFeedsAsync()
        {
            return JsonConvert.DeserializeObject<Result>(await client.GetStringAsync("api/feed")).Feed;
        }

        public async Task<FeedItem> GetFeedAsync(string Id)
        {
            return JsonConvert.DeserializeObject<FeedItem>(await client.GetStringAsync($"api/feed/{Id}"));
        }

        public async Task<TravelCards> GetTravelCardsAsync()
        {
            return JsonConvert.DeserializeObject<TravelCards>(await client.GetStringAsync("api/card/travel"));
        }

        public async Task<List<Trip>> GetTravelCardHistoryAsync(int Id)
        {
            return JsonConvert.DeserializeObject<Result>(await client.GetStringAsync($"api/card/travel/{Id}/history")).Trips;
        }

        public async Task<SmartCardInfo> GetSmartCardInfoAsync(int Id)
        {
            return JsonConvert.DeserializeObject<SmartCardInfo>(await client.GetStringAsync($"api/card/travel/{Id}/feed"));
        }
    }
}