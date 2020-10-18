using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class SmartCard
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("actions")]
        public Actions Actions { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("locked_at")]
        public object LockedAt { get; set; }
        [JsonProperty("balance")]
        public int Balance { get; set; }
        [JsonProperty("balance_wallet")]
        public int BalanceWallet { get; set; }
        [JsonProperty("monthly_ticket")]
        public MonthlyTicket MonthlyTicket { get; set; }
        [JsonProperty("monthly_ticket_purchase")]
        public MonthlyTicketPurchase MonthlyTicketPurchase { get; set; }
    }
}