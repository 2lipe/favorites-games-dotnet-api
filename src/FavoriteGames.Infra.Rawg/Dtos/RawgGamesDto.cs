using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgGamesDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("released")]
        public string Released { get; set; }

        [JsonPropertyName("tba")]
        public bool Tba { get; set; }

        [JsonPropertyName("background_image")]
        public string BackgroundImage { get; set; }

        [JsonPropertyName("rating")]
        public double Rating { get; set; }

        [JsonPropertyName("rating_top")]
        public int RatingTop { get; set; }

        [JsonPropertyName("ratings")]
        public List<RawgRatingDto> Ratings { get; set; }

        [JsonPropertyName("ratings_count")]
        public int RatingsCount { get; set; }

        [JsonPropertyName("reviews_text_count")]
        public int ReviewsTextCount { get; set; }

        [JsonPropertyName("added")]
        public int Added { get; set; }

        [JsonPropertyName("added_by_status")]
        public RawgAddedByStatusDto AddedByStatus { get; set; }

        [JsonPropertyName("metacritic")]
        public int Metacritic { get; set; }

        [JsonPropertyName("playtime")]
        public int Playtime { get; set; }

        [JsonPropertyName("suggestions_count")]
        public int SuggestionsCount { get; set; }

        [JsonPropertyName("updated")]
        public DateTime Updated { get; set; }

        [JsonPropertyName("user_game")]
        public object UserGame { get; set; }

        [JsonPropertyName("reviews_count")]
        public int ReviewsCount { get; set; }

        [JsonPropertyName("saturated_color")]
        public string SaturatedColor { get; set; }

        [JsonPropertyName("dominant_color")]
        public string DominantColor { get; set; }

        [JsonPropertyName("platforms")]
        public List<RawgPlatformDto> Platforms { get; set; }

        [JsonPropertyName("parent_platforms")]
        public List<RawgParentPlatformDto> ParentPlatforms { get; set; }

        [JsonPropertyName("genres")]
        public List<RawgGenreDto> Genres { get; set; }

        [JsonPropertyName("stores")]
        public List<RawgStoreDto> Stores { get; set; }

        [JsonPropertyName("clip")]
        public object Clip { get; set; }

        [JsonPropertyName("tags")]
        public List<RawgTagDto> Tags { get; set; }

        [JsonPropertyName("esrb_rating")]
        public RawgEsrbRatingDto EsrbRating { get; set; }

        [JsonPropertyName("short_screenshots")]
        public List<RawgShortScreenshotDto> ShortScreenshots { get; set; }
    }
}