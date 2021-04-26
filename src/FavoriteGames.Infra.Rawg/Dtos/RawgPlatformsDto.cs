using Newtonsoft.Json;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgPlatformDto
    {
        [JsonProperty("platform")]
        public PlatformDto Platform { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("requirements_en")]
        public object RequirementsEn { get; set; }

        [JsonProperty("requirements_ru")]
        public object RequirementsRu { get; set; }
    }
    
    public class PlatformDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("games_count")]
        public int GamesCount { get; set; }
    }
}