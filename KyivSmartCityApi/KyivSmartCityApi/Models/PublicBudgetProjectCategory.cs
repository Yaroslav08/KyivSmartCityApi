using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class PublicBudgetProjectCategory
    {
        [JsonPropertyName("id")]
        private int Id { get; set; }
        [JsonPropertyName("name")]
        private string Name { get; set; }
        [JsonPropertyName("color")]
        private string Color { get; set; }
        [JsonPropertyName("isSelected")]
        private bool IsSelected { get; set; }
        [JsonPropertyName("icon")]
        private string Icon { get; set; }
    }
}