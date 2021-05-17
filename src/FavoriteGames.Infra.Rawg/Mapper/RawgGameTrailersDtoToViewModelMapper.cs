using AutoMapper;
using FavoriteGames.Infra.Rawg.Dtos;
using FavoriteGames.Infra.Rawg.ViewModels;

namespace FavoriteGames.Infra.Rawg.Mapper
{
    public class RawgGameTrailersDtoToViewModelMapper : Profile
    {
        public RawgGameTrailersDtoToViewModelMapper()
        {
            CreateMap<RawgGamesResultDto<RawgGameTrailersDto>, RawgGamesResultViewModel<RawgGameTrailersViewModel>>();
            CreateMap<RawgGameTrailersDto, RawgGameTrailersViewModel>();
            CreateMap<TrailerDataDto, TrailerDataViewModel>();
        }
    }
}