using KyivSmartCityApi.Settings;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Event
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("Address")]
        public string Address { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("body")]
        public string Body { get; set; }
        [JsonPropertyName("start_date")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        public DateTime StartDate { get; set; }
        [JsonPropertyName("finish_date")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        public DateTime FinishDate { get; set; }
        [JsonPropertyName("average_bill")]
        public string AverageBill { get; set; }
        [JsonPropertyName("image")]
        public string Image { get; set; }
        [JsonPropertyName("lat")]
        public double Lat { get; set; }
        [JsonPropertyName("lng")]
        public double Lng { get; set; }
        [JsonPropertyName("ticket_mode")]
        public string TicketMode { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("url_buy_tickets")]
        public string UrlBuyTickets { get; set; }
        [JsonPropertyName("url_social")]
        public string UrlSocial { get; set; }
    }
}