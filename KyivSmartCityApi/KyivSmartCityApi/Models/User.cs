using KyivSmartCityApi.Settings;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("open_id")]
        public int OpenId { get; set; }
        [JsonPropertyName("first_name")]
        public string Firstname { get; set; }
        [JsonPropertyName("middle_name")]
        public string Middlename { get; set; }
        [JsonPropertyName("last_name")]
        public string Lastname { get; set; }
        [JsonPropertyName("birthday")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        public DateTime Birthday { get; set; }
        [JsonPropertyName("gender")]
        public int Gender { get; set; }
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
        [JsonPropertyName("accounts")]
        public List<Account> Accounts { get; set; }
        [JsonPropertyName("login")]
        public Login Login { get; set; }
        [JsonPropertyName("qrs_count")]
        public int QRsCount { get; set; }
        [JsonPropertyName("travel_cards_count")]
        public int TravelCardsCount { get; set; }
        [JsonPropertyName("bank_cards_count")]
        public int BankCardsCount { get; set; }
        [JsonPropertyName("bankid_connected")]
        public bool BankIdConnected { get; set; }
        [JsonPropertyName("feedback_email")]
        public string FeedbackEmail { get; set; }
    }
}