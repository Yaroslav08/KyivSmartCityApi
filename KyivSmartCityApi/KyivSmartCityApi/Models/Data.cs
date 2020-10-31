using KyivSmartCityApi.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Data
    {
        [JsonProperty("id")]
        private long Id { get; set; }
        [JsonProperty("title")]
        private string Title { get; set; }
        [JsonProperty("address")]
        private string Address { get; set; }
        [JsonProperty("averageBill")]
        private string AverageBill { get; set; }
        [JsonProperty("startDate")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        private DateTime StartDate { get; set; }
        [JsonProperty("finishDate")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        private DateTime FinishDate { get; set; }
        [JsonProperty("image")]
        private string Image { get; set; }
        [JsonProperty("ticketMode")]
        private string TicketMode { get; set; }
    }
}