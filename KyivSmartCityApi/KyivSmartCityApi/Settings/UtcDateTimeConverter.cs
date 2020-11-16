using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace KyivSmartCityApi.Settings
{
    public class UtcDateTimeConverter : JsonConverter
    {
        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer)
        {
            long ts = serializer.Deserialize<long>(reader);

            DateTime sTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return sTime.AddSeconds(ts);
        }

        public override bool CanConvert(Type type)
        {
            return typeof(DateTime).IsAssignableFrom(type);
        }

        public override void WriteJson(
            JsonWriter writer,
            object value,
            JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanRead
        {
            get { return true; }
        }
    }
}
