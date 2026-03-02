using System.Text.Json.Serialization;

namespace ConsumerPokeApi.models
{
    public class PokeModel
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }

        [JsonPropertyName("weight")]
        public int? Weight { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}