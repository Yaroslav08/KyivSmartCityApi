using KyivSmartCityApi.Models;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using KyivSmartCityApi.Settings;

namespace KyivSmartCityApi
{
    public class KyivApiClient
    {
        private string accessToken;
        private readonly HttpClient httpClient;
        public KyivApiClient(string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException($"{nameof(accessToken)} is null");
            this.accessToken = accessToken;
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Config.KyivApiUrl);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        }


        public async Task<SmartCard> AddSmartCard(CreateSmartCardModel model)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(model);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var res = await httpClient.PostAsJsonAsync("api/card/travel/add", data);
            return JsonSerializer.Deserialize<SmartCard>(await res.Content.ReadAsStringAsync());
        }

        public async Task<ResponseBase> RemoveBankCardByIdAsync(int Id)
        {
            return System.Text.Json.JsonSerializer.Deserialize<ResponseBase>(await httpClient.DeleteAsync($"api/card/bank/{Id}").Result.Content.ReadAsStringAsync());
        }

        public async Task<Headline> GetHeadlineAsync()
        {
            return await httpClient.GetFromJsonAsync<Headline>("api/headline");
        }

        public async Task<Phone> GetMasterpassPhone()
        {
            return await httpClient.GetFromJsonAsync<Phone>("api/card/bank/phone");
        }

        public async Task<TokenModel> RefreshAuth()
        {
            var tokenModel = JsonSerializer.Deserialize<TokenModel>(await httpClient.PostAsync("api/auth/refresh", null).Result.Content.ReadAsStringAsync());
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenModel.AccessToken);
            return tokenModel;
        }

        public async Task<User> GetUserAsync()
        {
            return await httpClient.GetFromJsonAsync<User>("api/user/profile");
        }

        public async Task<ListDocuments> GetDocumentsAsync()
        {
            return await httpClient.GetFromJsonAsync<ListDocuments>("api/user/documents");
        }

        public async Task<Document> GetDocumentByIdAsync(int Id)
        {
            return await httpClient.GetFromJsonAsync<Document>($"api/user/documents/{Id}");
        }

        public async Task<ListBankCards> GetBankCardsAsync()
        {
            return await httpClient.GetFromJsonAsync<ListBankCards>("api/card/bank");
        }

        public async Task<ListAddresses> GetAddressesAsync()
        {
            return await httpClient.GetFromJsonAsync<ListAddresses>("api/user/addresses");
        }

        public async Task<List<Feed>> GetFeedsAsync()
        {
            return JsonSerializer.Deserialize<Result>(await httpClient.GetStringAsync("api/feed")).Feed;
        }

        public async Task<FeedItem> GetFeedByIdAsync(string Id)
        {
            return await httpClient.GetFromJsonAsync<FeedItem>($"api/feed/{Id}");
        }

        public async Task<TravelCards> GetTravelCardsAsync()
        {
            return await httpClient.GetFromJsonAsync<TravelCards>("api/card/travel");
        }

        public async Task<List<Trip>> GetTravelCardHistoryByIdAsync(int Id)
        {
            return JsonSerializer.Deserialize<Result>(await httpClient.GetStringAsync($"api/card/travel/{Id}/history")).Trips;
        }

        public async Task<SmartCardInfo> GetSmartCardInfoByIdAsync(int Id)
        {
            return await httpClient.GetFromJsonAsync<SmartCardInfo>($"api/card/travel/{Id}/feed");
        }

        public async Task<Subscription> GetSubscriptionsAsync()
        {
            return await httpClient.GetFromJsonAsync<Subscription>("api/user/subscriptions");
        }

        public async Task<QrCodes> GetQrCodesAsync()
        {
            return await httpClient.GetFromJsonAsync<QrCodes>("api/qr");
        }

        public async Task<ZonePrices> GetZonePricesAsync()
        {
            return await httpClient.GetFromJsonAsync<ZonePrices>("api/parking/prices");
        }

        public async Task<WalletReplenish> GetWalletReplenishmentDataByIdAsync(long Id)
        {
            return await httpClient.GetFromJsonAsync<WalletReplenish>($"api/card/travel/{Id}/wallet-replenishment");
        }

        public async Task<CommunalAddresses> GetCommunalAddressesAsync()
        {
            return await httpClient.GetFromJsonAsync<CommunalAddresses>($"api/utility-objects");
        }

        public async Task<CommunalAddresse> GetCommunalAddresseByIdAsync(long Id)
        {
            return await httpClient.GetFromJsonAsync<CommunalAddresse>($"api/utility-objects/{Id}");
        }

        public async Task<AoAddress> GetAosAsync(string street, string search)
        {
            return await httpClient.GetFromJsonAsync<AoAddress>($"api/guess/address/ao?street={street}&search={search}");
        }

        public async Task<Cars> GetCarsAsync()
        {
            return await httpClient.GetFromJsonAsync<Cars>($"api/cars");
        }

        public async Task<CategoriesFaq> GetCategoriesFaqAsync(string query, int withtop)
        {
            return await httpClient.GetFromJsonAsync<CategoriesFaq>($"api/faq?query={query}&with_top={withtop}");
        }

        public async Task<StreetAddresses> GetCommunalStreetsAsync(string search)
        {
            return await httpClient.GetFromJsonAsync<StreetAddresses>($"api/guess/utility-object/street?search={search}");
        }

        public async Task<FeedEvacuation> GetEvacuationFeedByIdAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<FeedEvacuation>($"api/feed/{id}");
        }

        public async Task<Event> GetEventByIdAsync(long id)
        {
            return await httpClient.GetFromJsonAsync<Event>($"api/kyiv-events/{id}");
        }

        public async Task<EventsResponse> GetEventsAsync(string type, long category = default, int page = default, double lat = default, double lng = default)
        {
            return await httpClient.GetFromJsonAsync<EventsResponse>($"api/kyiv-events?type={type}&category={category}&page={page}&lat={lat}&lng={lng}");
        }

        public async Task<ExpiringQRs> GetExpiringQRsFeedAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<ExpiringQRs>($"api/feed/{id}");
        }

        public async Task<FaqDetail> GetFaqDetailByIdAsync(long id)
        {
            return await httpClient.GetFromJsonAsync<FaqDetail>($"api/faq/{id}");
        }

        public async Task<FeedFine> GetFineFeedByIdAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<FeedFine>($"api/feed/{id}");
        }

        public async Task<FineOrderReceipt> GetFineOrderReceiptByIdAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<FineOrderReceipt>($"api/order-receipt/{id}");
        }

        public async Task<FinePayment> GetFinePaymentDetailsByIdAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<FinePayment>($"api/penalties/{id}");
        }

        public async Task<FinesPaymentFeed> GetFinePaymentsFeedAsync(int page = 1)
        {
            return await httpClient.GetFromJsonAsync<FinesPaymentFeed>($"api/penalties/feed?page={page}");
        }

        public async Task<Fines> GetFinesAsync()
        {
            return await httpClient.GetFromJsonAsync<Fines>($"api/penalties");
        }

        public async Task<FinesRegions> GetFinesRegionsAsync()
        {
            return await httpClient.GetFromJsonAsync<FinesRegions>($"api/penalties/regions");
        }

        public async Task<PublicBudget> GetGbProjectsAsync(int page = default, int seed = default, string search = null, List<int> districts = null, List<int> categories = null)
        {
            return await httpClient.GetFromJsonAsync<PublicBudget>($"api/gb/projects?page={page}&seed={seed}&search={search}&districts={districts}&categories={categories}");
        }

        public async Task<PublicBudget> GetGbVotedProjectsAsync(int page = 1)
        {
            return await httpClient.GetFromJsonAsync<PublicBudget>($"api/gb/projects/voted?page={page}");
        }

        public async Task<HourlyParking> GetHourlyParkingAsync()
        {
            return await httpClient.GetFromJsonAsync<HourlyParking>($"api/hourly-parking/data");
        }

        public async Task<HourlyParkingFeed> GetHourlyParkingFeedAsync(int page = 1)
        {
            return await httpClient.GetFromJsonAsync<HourlyParkingFeed>($"api/hourly-parking/feed");
        }

        public async Task<HourlyParkingFreeTimes> GetHourlyParkingFreeTimesAsync()
        {
            return await httpClient.GetFromJsonAsync<HourlyParkingFreeTimes>($"api/hourly-parking/free-hours");
        }

        public async Task<FeedInfo> GetInfoFeedById(string id)
        {
            return await httpClient.GetFromJsonAsync<FeedInfo>($"api/feed/{id}");
        }

        public async Task<KyivSmartCash> GetKyivSmartCash()
        {
            return await httpClient.GetFromJsonAsync<KyivSmartCash>($"api/kyivstar-money/data");
        }

        public async Task<KyivSmartCashPhone> GetKyivSmartCashPhone()
        {
            return await httpClient.GetFromJsonAsync<KyivSmartCashPhone>($"api/kyivstar-money/phone");
        }
    }
}