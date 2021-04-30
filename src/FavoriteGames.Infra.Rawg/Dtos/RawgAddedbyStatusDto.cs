using System.Text.Json.Serialization;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgAddedByStatusDto
    {
        [JsonPropertyName("yet")]
        public int Yet { get; set; }

        [JsonPropertyName("owned")]
        public int Owned { get; set; }

        [JsonPropertyName("beaten")]
        public int Beaten { get; set; }

        [JsonPropertyName("toplay")]
        public int Toplay { get; set; }

        [JsonPropertyName("dropped")]
        public int Dropped { get; set; }

        [JsonPropertyName("playing")]
        public int Playing { get; set; }
    }
}