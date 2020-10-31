using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class CategoriesFaq
    {
        [JsonProperty("link_1551")]
        public string Link1551 { get; set; }
        [JsonProperty("categories")]
        public List<CategoryFaq> CategoryFaqs { get; set; }
    }
}