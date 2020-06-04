using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace console
{
    public class SensitiveStringJsonConverter : JsonConverter<SensitiveString>
    {
        public SensitiveStringJsonConverter()
        {
        }       

        public override SensitiveString ReadJson(JsonReader reader, Type objectType, [AllowNull] SensitiveString existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, [AllowNull] SensitiveString sensitiveString, JsonSerializer serializer)
        {
            writer.WriteValue(sensitiveString.ToSecureString());
        }
    }
}