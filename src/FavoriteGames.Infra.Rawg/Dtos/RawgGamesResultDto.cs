using System.Collections.Generic;
using Newtonsoft.Json;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgGamesResultDto<T>
    {
        [JsonProperty("count")] 
        public int Count { get; set; }

        [JsonProperty("next")] 
        public string Next { get; set; }

        [JsonProperty("previous")] 
        public object Previous { get; set; }

        [JsonProperty("results")] 
        public List<T> Results { get; set; }
    }
}
