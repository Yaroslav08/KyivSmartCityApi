using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Address
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("main")]
        public bool Main { get; set; }
        [JsonProperty("postcode")]
        public string PostCode { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("area")]
        public string Area { get; set; }
        [JsonProperty("district")]
        public string District { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("street")]
        public string Street { get; set; }
        [JsonProperty("house")]
        public string House { get; set; }
        [JsonProperty("frame")]
        public string Frame { get; set; }
        [JsonProperty("flat")]
        public string Flat { get; set; }
        [JsonProperty("street_id")]
        public string StreetId { get; set; }
        [JsonProperty("ao_id")]
        public string AoId { get; set; }
        [JsonProperty("premise_id")]
        public string PremiseId { get; set; }
    }
}