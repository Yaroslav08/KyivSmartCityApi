using KyivSmartCityApi.Settings;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ActiveSession
    {
        [JsonPropertyName("id")]
        private int Id { get; set; }
        [JsonPropertyName("created_at")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        private DateTime CreatedAt { get; set; }
        [JsonPropertyName("car")]
        private Car Car { get; set; }
        [JsonPropertyName("lasts_for")]
        private long LastsFor { get; set; }
        [JsonPropertyName("place")]
        private HourlyParkingZone Place { get; set; }
        [JsonPropertyName("sum")]
        private int Sum { get; set; }
    }
}