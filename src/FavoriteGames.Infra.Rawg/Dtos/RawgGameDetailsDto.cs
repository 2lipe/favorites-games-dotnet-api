using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FavoriteGames.Infra.Rawg.Dtos
{
    public class RawgGameDetailsDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("name_original")]
        public string NameOriginal { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("metacritic")]
        public int Metacritic { get; set; }

        [JsonPropertyName("metacritic_platforms")]
        public List<RawgMetacritcPlataformDto> MetacriticPlatforms { get; set; }

        [JsonPropertyName("released")]
        public string Released { get; set; }

        [JsonPropertyName("tba")]
        public bool Tba { get; set; }

        [JsonPropertyName("updated")]
        public DateTime Updated { get; set; }

        [JsonPropertyName("background_image")]
        public string BackgroundImage { get; set; }

        [JsonPropertyName("background_image_additional")]
        public string BackgroundImageAdditional { get; set; }

        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("rating")]
        public double Rating { get; set; }

        [JsonPropertyName("rating_top")]
        public int RatingTop { get; set; }

        [JsonPropertyName("ratings")]
        public List<RawgRatingDto> Ratings { get; set; }

        [JsonPropertyName("reactions")]
        public RawgReactionsDto Reactions { get; set; }

        [JsonPropertyName("added")]
        public int Added { get; set; }

        [JsonPropertyName("added_by_status")]
        public RawgAddedByStatusDto AddedByStatus { get; set; }

        [JsonPropertyName("playtime")]
        public int Playtime { get; set; }

        [JsonPropertyName("screenshots_count")]
        public int ScreenshotsCount { get; set; }

        [JsonPropertyName("movies_count")]
        public int MoviesCount { get; set; }

        [JsonPropertyName("creators_count")]
        public int CreatorsCount { get; set; }

        [JsonPropertyName("achievements_count")]
        public int AchievementsCount { get; set; }

        [JsonPropertyName("parent_achievements_count")]
        public int ParentAchievementsCount { get; set; }

        [JsonPropertyName("reddit_url")]
        public string RedditUrl { get; set; }

        [JsonPropertyName("reddit_name")]
        public string RedditName { get; set; }

        [JsonPropertyName("reddit_description")]
        public string RedditDescription { get; set; }

        [JsonPropertyName("reddit_logo")]
        public string RedditLogo { get; set; }

        [JsonPropertyName("reddit_count")]
        public int RedditCount { get; set; }

        [JsonPropertyName("twitch_count")]
        public int TwitchCount { get; set; }

        [JsonPropertyName("youtube_count")]
        public int YoutubeCount { get; set; }

        [JsonPropertyName("reviews_text_count")]
        public int ReviewsTextCount { get; set; }

        [JsonPropertyName("ratings_count")]
        public int RatingsCount { get; set; }

        [JsonPropertyName("suggestions_count")]
        public int SuggestionsCount { get; set; }

        [JsonPropertyName("alternative_names")]
        public List<string> AlternativeNames { get; set; }

        [JsonPropertyName("metacritic_url")]
        public string MetacriticUrl { get; set; }

        [JsonPropertyName("parents_count")]
        public int ParentsCount { get; set; }

        [JsonPropertyName("additions_count")]
        public int AdditionsCount { get; set; }

        [JsonPropertyName("game_series_count")]
        public int GameSeriesCount { get; set; }

        [JsonPropertyName("user_game")]
        public object UserGame { get; set; }

        [JsonPropertyName("reviews_count")]
        public int ReviewsCount { get; set; }

        [JsonPropertyName("saturated_color")]
        public string SaturatedColor { get; set; }

        [JsonPropertyName("dominant_color")]
        public string DominantColor { get; set; }

        [JsonPropertyName("parent_platforms")]
        public List<RawgParentPlatformDto> ParentPlatforms { get; set; }

        [JsonPropertyName("platforms")]
        public List<RawgPlatformDto> Platforms { get; set; }

        [JsonPropertyName("stores")]
        public List<RawgStoreDto> Stores { get; set; }

        [JsonPropertyName("developers")]
        public List<RawgDeveloperDto> Developers { get; set; }

        [JsonPropertyName("genres")]
        public List<RawgGenreDto> Genres { get; set; }

        [JsonPropertyName("tags")]
        public List<RawgTagDto> Tags { get; set; }

        [JsonPropertyName("publishers")]
        public List<RawgPublisherDto> Publishers { get; set; }

        [JsonPropertyName("esrb_rating")]
        public RawgEsrbRatingDto EsrbRating { get; set; }

        [JsonPropertyName("clip")]
        public object Clip { get; set; }

        [JsonPropertyName("description_raw")]
        public string DescriptionRaw { get; set; }
    }
}