using System.Text.Json.Serialization;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class PlatformDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("year_end")]
        public int? YearEnd { get; set; }

        [JsonPropertyName("year_start")]
        public int? YearStart { get; set; }

        [JsonPropertyName("games_count")]
        public int GamesCount { get; set; }

        [JsonPropertyName("image_background")]
        public string ImageBackground { get; set; }        
    }
}