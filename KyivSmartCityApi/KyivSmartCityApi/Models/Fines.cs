using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class Fines
    {
        [JsonPropertyName("cars")]
        public List<Car> Cars { get; set; }
        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; }
        [JsonPropertyName("faq_category_id")]
        public int FaqCategoryId { get; set; }
        [JsonPropertyName("pending_penalties")]
        public List<PendingPenalty> PendingPenalties { get; set; }
    }
}