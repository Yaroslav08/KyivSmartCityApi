using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Models
{

    public class Subscription
    {
        [JsonProperty("notifications_enabled")]
        public bool NotificationsEnabled { get; set; }
        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }
    }

    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("topics")]
        public List<Topic> Topics { get; set; }
    }

    public class Topic
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }
    }
}
