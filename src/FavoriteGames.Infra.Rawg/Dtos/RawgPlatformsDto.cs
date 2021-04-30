using System;
using System.Text.Json.Serialization;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgPlatformDto
    {
        [JsonPropertyName("platform")]
        public PlatformDto Platform { get; set; }

        [JsonPropertyName("released_at")]
        public string ReleasedAt { get; set; }

        [JsonPropertyName("requirements_en")]
        public RequirementsDto RequirementsEn { get; set; }

        [JsonPropertyName("requirements_ru")]
        public RequirementsDto RequirementsRu { get; set; }
    }
    
    public class RequirementsDto
    {
        [JsonPropertyName("minimum")]
        public string Minimum { get; set; }

        [JsonPropertyName("recommended")]
        public string Recommended { get; set; }
    }
    
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
    
    public class RawgParentPlatformDto
    {
        [JsonPropertyName("platform")]
        public PlatformDto Platform { get; set; }
    }
}