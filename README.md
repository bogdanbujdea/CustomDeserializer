CustomDeserializer


```
public class UploadImageModel
{
    [JsonConverter(typeof(Base64FileJsonConverter))]
    public byte[] Image { get; set; }

    public string ImageName { get; set; }
}

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
```