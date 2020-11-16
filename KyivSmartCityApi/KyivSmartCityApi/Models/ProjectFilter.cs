using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ProjectFilter
    {
        [JsonPropertyName("categories")]
        public List<PublicBudgetProjectCategory> Categories { get; set; }
        [JsonPropertyName("districts")]
        public List<ProjectDistrict> Districts;
    }
}