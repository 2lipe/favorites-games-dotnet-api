using System.Collections.Generic;
using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgGamesViewModel : BaseDataTransferObject
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Released { get; set; }
        public string BackgroundImage { get; set; }
        public double Rating { get; set; }
        public int Metacritic { get; set; }
        public int ReviewsCount { get; set; }
        public List<RawgRatingViewModel> Ratings { get; set; }
        public List<RawgPlatformViewModel> Platforms { get; set; }
        public List<RawgParentPlatformViewModel> ParentPlatforms { get; set; }
        public List<RawgGenreViewModel> Genres { get; set; }
        public List<RawgStoreViewModel> Stores { get; set; }
        public List<RawgTagViewModel> Tags { get; set; }
        public RawgEsrbRatingViewModel EsrbRating { get; set; }
        public List<RawgShortScreenshotViewModel> ShortScreenshots { get; set; }
        
        public override void Validate()
        {
        }
    }
}