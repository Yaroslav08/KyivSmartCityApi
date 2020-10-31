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
        private HttpClient httpClient;
        public KyivApiClient(string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException($"{nameof(accessToken)} is null");
            this.accessToken = accessToken;
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(KyivApiUrl);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        }


        public async Task<SmartCard> AddSmartCard(CreateSmartCardModel model)
        {
            var json = JsonConvert.SerializeObject(model);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var res = await httpClient.PostAsync("api/card/travel/add", data).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SmartCard>(res);
        }

        public async Task<Headline> GetHeadlineAsync()
        {
            return JsonConvert.DeserializeObject<Headline>(await httpClient.GetStringAsync("api/headline"));
        }

        public async Task<PhoneModel> GetMasterpassPhone()
        {
            return JsonConvert.DeserializeObject<PhoneModel>(await httpClient.GetStringAsync("api/card/bank/phone"));
        }

        public async Task<TokenModel> RefreshAuth()
        {
            var tokenModel = JsonConvert.DeserializeObject<TokenModel>(await httpClient.PostAsync("api/auth/refresh", null).Result.Content.ReadAsStringAsync());
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenModel.AccessToken);
            return tokenModel;
        }

        public async Task<User> GetUserAsync()
        {
            return JsonConvert.DeserializeObject<User>(await httpClient.GetStringAsync("api/user/profile"));
        }

        public async Task<ListDocuments> GetDocumentsAsync()
        {
            return JsonConvert.DeserializeObject<ListDocuments>(await httpClient.GetStringAsync("api/user/documents"));
        }

        public async Task<Document> GetDocumentAsync(int Id)
        {
            return JsonConvert.DeserializeObject<Document>(await httpClient.GetStringAsync($"api/user/documents/{Id}"));
        }

        public async Task<ListBankCards> GetBankCardsAsync()
        {
            return JsonConvert.DeserializeObject<ListBankCards>(await httpClient.GetStringAsync("api/card/bank"));
        }

        public async Task<ResponseBase> RemoveBankCardAsync(int Id)
        {
            return JsonConvert.DeserializeObject<ResponseBase>(await httpClient.DeleteAsync($"api/card/bank/{Id}").Result.Content.ReadAsStringAsync());
        }

        public async Task<ListAddresses> GetAddressesAsync()
        {
            return JsonConvert.DeserializeObject<ListAddresses>(await httpClient.GetStringAsync("api/user/addresses"));
        }

        public async Task<List<Feed>> GetFeedsAsync()
        {
            return JsonConvert.DeserializeObject<Result>(await httpClient.GetStringAsync("api/feed")).Feed;
        }

        public async Task<FeedItem> GetFeedAsync(string Id)
        {
            return JsonConvert.DeserializeObject<FeedItem>(await httpClient.GetStringAsync($"api/feed/{Id}"));
        }

        public async Task<TravelCards> GetTravelCardsAsync()
        {
            return JsonConvert.DeserializeObject<TravelCards>(await httpClient.GetStringAsync("api/card/travel"));
        }

        public async Task<List<Trip>> GetTravelCardHistoryAsync(int Id)
        {
            return JsonConvert.DeserializeObject<Result>(await httpClient.GetStringAsync($"api/card/travel/{Id}/history")).Trips;
        }

        public async Task<SmartCardInfo> GetSmartCardInfoAsync(int Id)
        {
            return JsonConvert.DeserializeObject<SmartCardInfo>(await httpClient.GetStringAsync($"api/card/travel/{Id}/feed"));
        }

        public async Task<Subscription> GetSubscriptionsAsync()
        {
            return JsonConvert.DeserializeObject<Subscription>(await httpClient.GetStringAsync("api/user/subscriptions"));
        }

        public async Task<QrCodes> GetQrCodesAsync()
        {
            return JsonConvert.DeserializeObject<QrCodes>(await httpClient.GetStringAsync("api/qr"));
        }

        public async Task<ZonePrices> GetZonePricesAsync()
        {
            return JsonConvert.DeserializeObject<ZonePrices>(await httpClient.GetStringAsync("api/parking/prices"));
        }

        public async Task<WalletReplenish> GetWalletReplenishmentDataAsync(long Id)
        {
            return JsonConvert.DeserializeObject<WalletReplenish>(await httpClient.GetStringAsync($"api/card/travel/{Id}/wallet-replenishment"));
        }

        public async Task<CommunalAddresses> GetCommunalAddressesAsync()
        {
            return JsonConvert.DeserializeObject<CommunalAddresses>(await httpClient.GetStringAsync($"api/utility-objects"));
        }

        public async Task<CommunalAddresse> GetCommunalAddresseAsync(long Id)
        {
            return JsonConvert.DeserializeObject<CommunalAddresse>(await httpClient.GetStringAsync($"api/utility-objects/{Id}"));
        }

        public async Task<AoAddress> GetAosAsync(string street, string search)
        {
            return JsonConvert.DeserializeObject<AoAddress>(await httpClient.GetStringAsync($"api/guess/address/ao?street={street}&search={search}"));
        }

        public async Task<Cars> GetCarsAsync()
        {
            return JsonConvert.DeserializeObject<Cars>(await httpClient.GetStringAsync($"api/cars"));
        }

        public async Task<CategoriesFaq> GetCategoriesFaqAsync(string query, int withtop)
        {
            return JsonConvert.DeserializeObject<CategoriesFaq>(await httpClient.GetStringAsync($"api/faq?query={query}&with_top={withtop}"));
        }

        public async Task<StreetAddresses> GetCommunalStreetsAsync(string search)
        {
            return JsonConvert.DeserializeObject<StreetAddresses>(await httpClient.GetStringAsync($"api/guess/utility-object/street?search={search}"));
        }
    }
}