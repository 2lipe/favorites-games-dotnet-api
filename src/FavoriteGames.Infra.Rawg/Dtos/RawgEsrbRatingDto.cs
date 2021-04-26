using Newtonsoft.Json;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgEsrbRatingDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}