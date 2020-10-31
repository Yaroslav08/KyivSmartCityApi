using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class PublicBudgetProjectCategory
    {
        [JsonProperty("id")]
        private int Id { get; set; }
        [JsonProperty("name")]
        private string Name { get; set; }
        [JsonProperty("color")]
        private string Color { get; set; }
        [JsonProperty("isSelected")]
        private bool IsSelected { get; set; }
        [JsonProperty("icon")]
        private string Icon { get; set; }
    }
}