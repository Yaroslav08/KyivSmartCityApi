using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class PublicBudgetProjects
    {
        [JsonProperty("data")]
        public List<PublicBudgetProject> Data { get; set; }
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}