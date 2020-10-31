using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Fines
    {
        [JsonProperty("cars")]
        public List<Car> Cars { get; set; }
        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }
        [JsonProperty("faq_category_id")]
        public int FaqCategoryId { get; set; }
        [JsonProperty("pending_penalties")]
        public List<PendingPenalty> PendingPenalties { get; set; }
    }
}