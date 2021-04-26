using Newtonsoft.Json;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgStoreDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("store")]
        public StoreDto Store { get; set; }
    }
    
    public class StoreDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("games_count")]
        public int GamesCount { get; set; }
    }
}