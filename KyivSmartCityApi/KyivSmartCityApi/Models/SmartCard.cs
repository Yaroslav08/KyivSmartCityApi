using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class SmartCard
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("type")]
        public int Type { get; set; }
        [JsonPropertyName("actions")]
        public Actions Actions { get; set; }
        [JsonPropertyName("code")]
        public string Code { get; set; }
        [JsonPropertyName("locked_at")]
        public object LockedAt { get; set; }
        [JsonPropertyName("balance")]
        public int Balance { get; set; }
        [JsonPropertyName("balance_wallet")]
        public int BalanceWallet { get; set; }
        [JsonPropertyName("monthly_ticket")]
        public MonthlyTicket MonthlyTicket { get; set; }
        [JsonPropertyName("monthly_ticket_purchase")]
        public MonthlyTicketPurchase MonthlyTicketPurchase { get; set; }
    }
}