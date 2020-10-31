using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class PublicBudget
    {
        [JsonProperty("faq_category_id")]
        private long FaqCategoryId { get; set; }
        [JsonProperty("filters")]
        private ProjectFilter Filters { get; set; }
        [JsonProperty("list_sub_title")]
        private string ListSubTitle { get; set; }
        [JsonProperty("list_title")]
        private string ListTitle { get; set; }
        [JsonProperty("notification")]
        private Notification Notification { get; set; }
        [JsonProperty("projects")]
        private PublicBudgetProjects Projects { get; set; }
        [JsonProperty("votes_info")]
        private string VotesInfo { get; set; }
    }
}