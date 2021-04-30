using AutoMapper;
using FavoriteGames.Infra.Rawg.Dtos;
using FavoriteGames.Infra.Rawg.ViewModels;

namespace FavoriteGames.Infra.Rawg.Mapper
{
    public class RawgGamesDtoToViewModelMapper : Profile
    {
        public RawgGamesDtoToViewModelMapper()
        {
            CreateMap<RawgGamesDto, RawgGamesViewModel>();
            CreateMap<RawgEsrbRatingDto, RawgEsrbRatingViewModel>();
            CreateMap<RawgGenreDto, RawgGenreViewModel>();
            CreateMap<PlatformDto, PlatformViewModel>();
            CreateMap<RequirementsDto, RequirementsViewModel>();
            CreateMap<RawgPlatformDto, RawgPlatformViewModel>();
            CreateMap<RawgParentPlatformDto, RawgParentPlatformViewModel>();
            CreateMap<RawgRatingDto, RawgRatingViewModel>();
            CreateMap<RawgShortScreenshotDto, RawgShortScreenshotViewModel>();
            CreateMap<StoreDto, StoreViewModel>();
            CreateMap<RawgStoreDto, RawgStoreViewModel>();
            CreateMap<RawgTagDto, RawgTagViewModel>();
        }
    }
}