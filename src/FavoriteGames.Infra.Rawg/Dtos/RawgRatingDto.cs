using System.Text.Json.Serialization;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgRatingDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("percent")]
        public double Percent { get; set; }
    }
}