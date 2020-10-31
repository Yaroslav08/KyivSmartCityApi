using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ProjectDistrict
    {
        [JsonProperty("id")]
        private int Id;
        [JsonProperty("isSelected")]
        private bool IsSelected;
        [JsonProperty("name")]
        private string Name;
    }
}