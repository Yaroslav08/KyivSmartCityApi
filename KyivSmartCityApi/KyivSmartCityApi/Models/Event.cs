using KyivSmartCityApi.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Event
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("Address")]
        public string Address { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("start_date")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        public DateTime StartDate { get; set; }
        [JsonProperty("finish_date")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        public DateTime FinishDate { get; set; }
        [JsonProperty("average_bill")]
        public string AverageBill { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("lat")]
        public double Lat { get; set; }
        [JsonProperty("lng")]
        public double Lng { get; set; }
        [JsonProperty("ticket_mode")]
        public string TicketMode { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("url_buy_tickets")]
        public string UrlBuyTickets { get; set; }
        [JsonProperty("url_social")]
        public string UrlSocial { get; set; }
    }
}