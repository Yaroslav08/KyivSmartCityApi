using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class StreetAddresses
    {
        [JsonPropertyName("streets")]
        public List<AddressPart> Streets { get; set; }
    }
}