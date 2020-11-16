using KyivSmartCityApi.Settings;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Data
    {
        [JsonPropertyName("id")]
        private long Id { get; set; }
        [JsonPropertyName("title")]
        private string Title { get; set; }
        [JsonPropertyName("address")]
        private string Address { get; set; }
        [JsonPropertyName("averageBill")]
        private string AverageBill { get; set; }
        [JsonPropertyName("startDate")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        private DateTime StartDate { get; set; }
        [JsonPropertyName("finishDate")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        private DateTime FinishDate { get; set; }
        [JsonPropertyName("image")]
        private string Image { get; set; }
        [JsonPropertyName("ticketMode")]
        private string TicketMode { get; set; }
    }
}