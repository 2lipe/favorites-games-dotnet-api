using System.Text.Json.Serialization;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgParentPlatformDto
    {
        [JsonPropertyName("platform")]
        public PlatformDto Platform { get; set; }        
    }
}