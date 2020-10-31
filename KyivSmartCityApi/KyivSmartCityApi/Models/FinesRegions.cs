using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class FinesRegions
    {
        [JsonProperty("regions")]
        public List<FinesRegion> Regions { get; set; }
    }
}