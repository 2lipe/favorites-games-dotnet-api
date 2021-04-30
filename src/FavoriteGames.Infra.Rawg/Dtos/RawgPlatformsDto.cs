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
}