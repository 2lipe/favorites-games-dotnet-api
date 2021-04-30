using System.Text.Json.Serialization;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgTagDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("games_count")]
        public int GamesCount { get; set; }

        [JsonPropertyName("image_background")]
        public string ImageBackground { get; set; }
    }
}