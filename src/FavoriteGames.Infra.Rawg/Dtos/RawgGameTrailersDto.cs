using System.Text.Json.Serialization;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgGameTrailersDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("preview")]
        public string Preview { get; set; }

        [JsonPropertyName("data")]
        public TrailerDataDto Data { get; set; }   
    }

    public class TrailerDataDto
    {
        [JsonPropertyName("480")]
        public string _480 { get; set; }

        [JsonPropertyName("max")]
        public string Max { get; set; }  
    }
}