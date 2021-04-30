using System.Text.Json.Serialization;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgStoreDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("store")]
        public StoreDto Store { get; set; }
    }
    
    public class StoreDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("games_count")]
        public int GamesCount { get; set; }

        [JsonPropertyName("image_background")]
        public string ImageBackground { get; set; }
    }
}