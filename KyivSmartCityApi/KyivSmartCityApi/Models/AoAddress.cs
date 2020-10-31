using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class AoAddress
    {
        [JsonProperty("aos")]
        public List<AddressPart> Addresses { get; set; }
    }
}