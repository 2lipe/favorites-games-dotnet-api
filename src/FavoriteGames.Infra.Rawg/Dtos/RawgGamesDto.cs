using System.Collections.Generic;
using Newtonsoft.Json;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgGamesDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("slug")]
        public string Slug { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("released")]
        public string Released { get; set; }
        
        [JsonProperty("background_image")]
        public string BackgroundImage { get; set; }
        
        [JsonProperty("rating")]
        public double Rating { get; set; }
        
        [JsonProperty("ratings_count")]
        public int RatingsCount { get; set; }
        
        [JsonProperty("metacritic")]
        public int Metacritic { get; set; }
        
        [JsonProperty("suggestions_count")]
        public int SuggestionsCount { get; set; }
        
        [JsonProperty("reviews_count")]
        public int ReviewsCount { get; set; }
        
        [JsonProperty("platforms")]
        public List<RawgPlatformDto> Platforms { get; set; }
        
        [JsonProperty("parent_platforms")]
        public List<PlatformDto> ParentPlatforms { get; set; }
        
        [JsonProperty("genres")]
        public List<RawgGenreDto> Genres { get; set; }
        
        [JsonProperty("stores")]
        public List<RawgStoreDto> Stores { get; set; }

        [JsonProperty("tags")]
        public List<RawgTagDto> Tags { get; set; }
        
        [JsonProperty("esrb_rating")]
        public RawgEsrbRatingDto EsrbRating { get; set; }
        
        [JsonProperty("short_screenshots")]
        public List<RawgShortScreenshotDto> ShortScreenshots { get; set; }
    }
}