using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FinesRegions
    {
        [JsonPropertyName("regions")]
        public List<FinesRegion> Regions { get; set; }
    }
}