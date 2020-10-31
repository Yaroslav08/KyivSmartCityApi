using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class StreetAddresses
    {
        [JsonProperty("streets")]
        public List<AddressPart> Streets { get; set; }
    }
}