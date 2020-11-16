using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{

    public class Subscription
    {
        [JsonPropertyName("notifications_enabled")]
        public bool NotificationsEnabled { get; set; }
        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; }
    }

    public class Category
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("topics")]
        public List<Topic> Topics { get; set; }
    }

    public class Topic
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("subscribed")]
        public bool Subscribed { get; set; }
    }
}
