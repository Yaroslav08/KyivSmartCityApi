using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Address
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("main")]
        public bool Main { get; set; }
        [JsonPropertyName("postcode")]
        public string PostCode { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("area")]
        public string Area { get; set; }
        [JsonPropertyName("district")]
        public string District { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("street")]
        public string Street { get; set; }
        [JsonPropertyName("house")]
        public string House { get; set; }
        [JsonPropertyName("frame")]
        public string Frame { get; set; }
        [JsonPropertyName("flat")]
        public string Flat { get; set; }
        [JsonPropertyName("street_id")]
        public string StreetId { get; set; }
        [JsonPropertyName("ao_id")]
        public string AoId { get; set; }
        [JsonPropertyName("premise_id")]
        public string PremiseId { get; set; }
    }
}