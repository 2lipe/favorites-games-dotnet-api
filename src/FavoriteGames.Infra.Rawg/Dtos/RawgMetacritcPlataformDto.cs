using System.Text.Json.Serialization;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgMetacritcPlataformDto
    {
        [JsonPropertyName("metascore")]
        public int Metascore { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("platform")]
        public MetacriticPlatformDto Platform { get; set; }  
    }
    
    public class MetacriticPlatformDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
    }
}