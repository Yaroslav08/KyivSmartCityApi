using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ProjectDistrict
    {
        [JsonPropertyName("id")]
        private int Id;
        [JsonPropertyName("isSelected")]
        private bool IsSelected;
        [JsonPropertyName("name")]
        private string Name;
    }
}