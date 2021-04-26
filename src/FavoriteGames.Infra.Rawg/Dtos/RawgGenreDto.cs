using Newtonsoft.Json;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgGenreDto
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