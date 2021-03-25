using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CustomDeserializer.Infrastructure
{
    public class Base64FileJsonConverter : JsonConverter<byte[]>
    {
        public override byte[] Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            return reader.GetBytesFromBase64();
        }

        public override void Write(Utf8JsonWriter writer, byte[] wf, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}