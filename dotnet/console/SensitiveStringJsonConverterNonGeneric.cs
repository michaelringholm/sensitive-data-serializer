using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace console
{
    public class SensitiveStringJsonConverterNonGeneric : JsonConverter
    {
        public SensitiveStringJsonConverterNonGeneric()
        {
        }

        public override bool CanConvert(Type objectType)
        {
            if(objectType == typeof(SensitiveString)) return true;
            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JToken t = JToken.FromObject(value);
            if (t.Type != JTokenType.Object)
            {
                t.WriteTo(writer);
            }
            else
            {
                JObject o = (JObject)t;
                var propertyName = o.Properties().Select(p => p.Name).Single();
                //o.AddFirst(new JProperty("Keys", new JArray(propertyNames)));
                //o.Add(propertyName, new JValue(value));
                //o.WriteTo(writer);
                var sensitiveString = (SensitiveString)value;
                writer.WriteValue(sensitiveString.ToSecureString());
            }
        }
    }
}