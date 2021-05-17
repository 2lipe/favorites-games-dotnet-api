using System;
using System.Collections.Generic;
using FavoriteGames.Infra.Rawg.Dtos;
using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgGamesDetailsViewModel : BaseDataTransferObject
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string NameOriginal { get; set; }
        public string Description { get; set; }
        public int Metacritic { get; set; }
        public List<RawgMetacritcPlataformDto> MetacriticPlatforms { get; set; }
        public string Released { get; set; }
        public DateTime Updated { get; set; }
        public string BackgroundImage { get; set; }
        public string BackgroundImageAdditional { get; set; }
        public string Website { get; set; }
        public double Rating { get; set; }
        public int RatingTop { get; set; }
        public List<RawgRatingViewModel> Ratings { get; set; }
        public int ScreenshotsCount { get; set; }
        public int MoviesCount { get; set; }
        public int CreatorsCount { get; set; }
        public int AchievementsCount { get; set; }
        public int ParentAchievementsCount { get; set; }
        public string RedditUrl { get; set; }
        public string RedditName { get; set; }
        public string RedditDescription { get; set; }
        public int RedditCount { get; set; }
        public int TwitchCount { get; set; }
        public int YoutubeCount { get; set; }
        public int RatingsCount { get; set; }
        public List<string> AlternativeNames { get; set; }
        public string MetacriticUrl { get; set; }
        public int ReviewsCount { get; set; }
        public List<RawgParentPlatformViewModel> ParentPlatforms { get; set; }
        public List<RawgPlatformViewModel> Platforms { get; set; }
        public List<RawgStoreViewModel> Stores { get; set; }
        public List<RawgDeveloperViewModel> Developers { get; set; }
        public List<RawgGenreViewModel> Genres { get; set; }
        public List<RawgTagViewModel> Tags { get; set; }
        public List<RawgPublisherViewModel> Publishers { get; set; }
        public RawgEsrbRatingViewModel EsrbRating { get; set; }
        public string DescriptionRaw { get; set; }
        
        public override void Validate()
        {
        }
    }
}