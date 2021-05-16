using AutoMapper;
using FavoriteGames.Infra.Rawg.Dtos;
using FavoriteGames.Infra.Rawg.ViewModels;

namespace FavoriteGames.Infra.Rawg.Mapper
{
    public class RawgGameDetailsDtoToViewModelMapper : Profile
    {
        public RawgGameDetailsDtoToViewModelMapper()
        {
            CreateMap<RawgGameDetailsDto, RawgGamesDetailsViewModel>();
            CreateMap<RawgDeveloperDto, RawgDeveloperViewModel>();
            CreateMap<RawgPublisherDto, RawgPublisherViewModel>();
            CreateMap<RawgMetacritcPlataformDto, RawgMetacritcPlatformViewModel>();
            CreateMap<MetacriticPlatformDto, MetacriticPlatformViewModel>();
            CreateMap<RawgEsrbRatingDto, RawgEsrbRatingViewModel>();
            CreateMap<RawgGenreDto, RawgGenreViewModel>();
            CreateMap<PlatformDto, PlatformViewModel>();
            CreateMap<RequirementsDto, RequirementsViewModel>();
            CreateMap<RawgPlatformDto, RawgPlatformViewModel>();
            CreateMap<RawgParentPlatformDto, RawgParentPlatformViewModel>();
            CreateMap<RawgRatingDto, RawgRatingViewModel>();
            CreateMap<StoreDto, StoreViewModel>();
            CreateMap<RawgStoreDto, RawgStoreViewModel>();
            CreateMap<RawgTagDto, RawgTagViewModel>();
        }
    }
}