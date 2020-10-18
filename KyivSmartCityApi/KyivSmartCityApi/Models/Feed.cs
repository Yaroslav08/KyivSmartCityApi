using KyivSmartCityApi.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{
    public class Feed
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("sub_icon")]
        public string SubIcon { get; set; }
        [JsonProperty("read")]
        public bool Read { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("value_sum")]
        public string ValueSum { get; set; }
        [JsonProperty("value_text")]
        public string ValueText { get; set; }
        [JsonProperty("value_img")]
        public string ValueImg { get; set; }
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UtcDateTimeConverter))]
        public DateTime CreatedAt { get; set; }
    }
}