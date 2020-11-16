using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class PublicBudgetProjects
    {
        [JsonPropertyName("data")]
        public List<PublicBudgetProject> Data { get; set; }
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}