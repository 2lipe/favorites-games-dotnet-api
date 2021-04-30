using System.Text.Json.Serialization;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RequirementsDto
    {
        [JsonPropertyName("minimum")] 
        public string Minimum { get; set; }
        
        [JsonPropertyName("recommended")]
        public string Recommended { get; set; }
    }
}