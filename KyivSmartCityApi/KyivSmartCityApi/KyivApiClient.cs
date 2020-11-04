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

        public async Task<Document> GetDocumentByIdAsync(int Id)
        {
            return JsonConvert.DeserializeObject<Document>(await httpClient.GetStringAsync($"api/user/documents/{Id}"));
        }

        public async Task<ListBankCards> GetBankCardsAsync()
        {
            return JsonConvert.DeserializeObject<ListBankCards>(await httpClient.GetStringAsync("api/card/bank"));
        }

        public async Task<ResponseBase> RemoveBankCardByIdAsync(int Id)
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

        public async Task<FeedItem> GetFeedByIdAsync(string Id)
        {
            return JsonConvert.DeserializeObject<FeedItem>(await httpClient.GetStringAsync($"api/feed/{Id}"));
        }

        public async Task<TravelCards> GetTravelCardsAsync()
        {
            return JsonConvert.DeserializeObject<TravelCards>(await httpClient.GetStringAsync("api/card/travel"));
        }

        public async Task<List<Trip>> GetTravelCardHistoryByIdAsync(int Id)
        {
            return JsonConvert.DeserializeObject<Result>(await httpClient.GetStringAsync($"api/card/travel/{Id}/history")).Trips;
        }

        public async Task<SmartCardInfo> GetSmartCardInfoByIdAsync(int Id)
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

        public async Task<WalletReplenish> GetWalletReplenishmentDataByIdAsync(long Id)
        {
            return JsonConvert.DeserializeObject<WalletReplenish>(await httpClient.GetStringAsync($"api/card/travel/{Id}/wallet-replenishment"));
        }

        public async Task<CommunalAddresses> GetCommunalAddressesAsync()
        {
            return JsonConvert.DeserializeObject<CommunalAddresses>(await httpClient.GetStringAsync($"api/utility-objects"));
        }

        public async Task<CommunalAddresse> GetCommunalAddresseByIdAsync(long Id)
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

        public async Task<FeedEvacuation> GetEvacuationFeedByIdAsync(string id)
        {
            return JsonConvert.DeserializeObject<FeedEvacuation>(await httpClient.GetStringAsync($"api/feed/{id}"));
        }

        public async Task<Event> GetEventByIdAsync(long id)
        {
            return JsonConvert.DeserializeObject<Event>(await httpClient.GetStringAsync($"api/kyiv-events/{id}"));
        }

        public async Task<EventsResponse> GetEventsAsync(string type, long category = default, int page = default, double lat = default, double lng = default)
        {
            return JsonConvert.DeserializeObject<EventsResponse>(await httpClient.GetStringAsync($"api/kyiv-events?type={type}&category={category}&page={page}&lat={lat}&lng={lng}"));
        }

        public async Task<ExpiringQRs> GetExpiringQRsFeedAsync(string id)
        {
            return JsonConvert.DeserializeObject<ExpiringQRs>(await httpClient.GetStringAsync($"api/feed/{id}"));
        }

        public async Task<FaqDetail> GetFaqDetailByIdAsync(long id)
        {
            return JsonConvert.DeserializeObject<FaqDetail>(await httpClient.GetStringAsync($"api/faq/{id}"));
        }

        public async Task<FeedFine> GetFineFeedByIdAsync(string id)
        {
            return JsonConvert.DeserializeObject<FeedFine>(await httpClient.GetStringAsync($"api/feed/{id}"));
        }

        public async Task<FineOrderReceipt> GetFineOrderReceiptByIdAsync(string id)
        {
            return JsonConvert.DeserializeObject<FineOrderReceipt>(await httpClient.GetStringAsync($"api/order-receipt/{id}"));
        }

        public async Task<FinePayment> GetFinePaymentDetailsByIdAsync(string id)
        {
            return JsonConvert.DeserializeObject<FinePayment>(await httpClient.GetStringAsync($"api/penalties/{id}"));
        }

        public async Task<FinesPaymentFeed> GetFinePaymentsFeedAsync(int page = 1)
        {
            return JsonConvert.DeserializeObject<FinesPaymentFeed>(await httpClient.GetStringAsync($"api/penalties/feed?page={page}"));
        }

        public async Task<Fines> GetFinesAsync()
        {
            return JsonConvert.DeserializeObject<Fines>(await httpClient.GetStringAsync($"api/penalties"));
        }

        public async Task<FinesRegions> GetFinesRegionsAsync()
        {
            return JsonConvert.DeserializeObject<FinesRegions>(await httpClient.GetStringAsync($"api/penalties/regions"));
        }

        public async Task<PublicBudget> GetGbProjectsAsync(int page = default, int seed = default, string search = null, List<int> districts = null, List<int> categories = null)
        {
            return JsonConvert.DeserializeObject<PublicBudget>(await httpClient.GetStringAsync($"api/gb/projects?page={page}&seed={seed}&search={search}&districts={districts}&categories={categories}"));
        }

        public async Task<PublicBudget> GetGbVotedProjectsAsync(int page = 1)
        {
            return JsonConvert.DeserializeObject<PublicBudget>(await httpClient.GetStringAsync($"api/gb/projects/voted?page={page}"));
        }

        public async Task<HourlyParking> GetHourlyParkingAsync()
        {
            return JsonConvert.DeserializeObject<HourlyParking>(await httpClient.GetStringAsync($"api/hourly-parking/data"));
        }

        public async Task<HourlyParkingFeed> GetHourlyParkingFeedAsync(int page = 1)
        {
            return JsonConvert.DeserializeObject<HourlyParkingFeed>(await httpClient.GetStringAsync($"api/hourly-parking/feed"));
        }

        public async Task<HourlyParkingFreeTimes> GetHourlyParkingFreeTimesAsync()
        {
            return JsonConvert.DeserializeObject<HourlyParkingFreeTimes>(await httpClient.GetStringAsync($"api/hourly-parking/free-hours"));
        }

        public async Task<FeedInfo> GetInfoFeed(string id)
        {
            return JsonConvert.DeserializeObject<FeedInfo>(await httpClient.GetStringAsync($"api/feed/{id}"));
        }
    }
}