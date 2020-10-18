using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("open_id")]
        public int OpenId { get; set; }
        [JsonProperty("first_name")]
        public string Firstname { get; set; }
        [JsonProperty("middle_name")]
        public string Middlename { get; set; }
        [JsonProperty("last_name")]
        public string Lastname { get; set; }
        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }
        [JsonProperty("gender")]
        public int Gender { get; set; }
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
        [JsonProperty("accounts")]
        public List<Account> Accounts { get; set; }
        [JsonProperty("login")]
        public Login Login { get; set; }
        [JsonProperty("qrs_count")]
        public int QRsCount { get; set; }
        [JsonProperty("travel_cards_count")]
        public int TravelCardsCount { get; set; }
        [JsonProperty("bank_cards_count")]
        public int BankCardsCount { get; set; }
        [JsonProperty("bankid_connected")]
        public bool BankIdConnected { get; set; }
        [JsonProperty("feedback_email")]
        public string FeedbackEmail { get; set; }
    }
}