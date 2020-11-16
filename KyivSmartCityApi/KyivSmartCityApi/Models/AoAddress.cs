using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class AoAddress
    {
        [JsonPropertyName("aos")]
        public List<AddressPart> Addresses { get; set; }
    }
}