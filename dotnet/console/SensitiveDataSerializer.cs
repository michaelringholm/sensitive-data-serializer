using System;
using Newtonsoft.Json;

namespace console
{
    public class SensitiveDataSerializer
    {
        public SensitiveDataSerializer()
        {
        }

        public string Serialize(MyPartlySensitiveObject partlySensitiveObject)
        {
            //var sensitiveStringConverter = new SensitiveStringJsonConverterNonGeneric();
            var sensitiveStringConverter = new SensitiveStringJsonConverter();
            var converters = new JsonConverter[1];
            converters[0] = sensitiveStringConverter;
            var json = JsonConvert.SerializeObject(partlySensitiveObject, converters);
            return json;
        }
    }
}