using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class ProjectFilter
    {
        [JsonProperty("categories")]
        public List<PublicBudgetProjectCategory> Categories { get; set; }
        [JsonProperty("districts")]
        public List<ProjectDistrict> Districts;
    }
}