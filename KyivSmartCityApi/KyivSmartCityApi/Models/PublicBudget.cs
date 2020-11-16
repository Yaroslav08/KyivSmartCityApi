using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class PublicBudget
    {
        [JsonPropertyName("faq_category_id")]
        private long FaqCategoryId { get; set; }
        [JsonPropertyName("filters")]
        private ProjectFilter Filters { get; set; }
        [JsonPropertyName("list_sub_title")]
        private string ListSubTitle { get; set; }
        [JsonPropertyName("list_title")]
        private string ListTitle { get; set; }
        [JsonPropertyName("notification")]
        private Notification Notification { get; set; }
        [JsonPropertyName("projects")]
        private PublicBudgetProjects Projects { get; set; }
        [JsonPropertyName("votes_info")]
        private string VotesInfo { get; set; }
    }
}