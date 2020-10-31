using KyivSmartCityApi.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ActiveSession
    {
        [JsonProperty("id")]
        private int Id { get; set; }
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        private DateTime CreatedAt { get; set; }
        [JsonProperty("car")]
        private Car Car { get; set; }
        [JsonProperty("lasts_for")]
        private long LastsFor { get; set; }
        [JsonProperty("place")]
        private HourlyParkingZone Place { get; set; }
        [JsonProperty("sum")]
        private int Sum { get; set; }
    }
}