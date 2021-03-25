using System.Text.Json.Serialization;
using CustomDeserializer.Infrastructure;

namespace CustomDeserializer.Models
{
    public class UploadImageModel
    {
        [JsonConverter(typeof(Base64FileJsonConverter))]
        public byte[] Image { get; set; }

        public string ImageName { get; set; }
    }
}