using AutoMapper;
using FavoriteGames.Infra.Rawg.Dtos;
using FavoriteGames.Infra.Rawg.ViewModels;

namespace FavoriteGames.Infra.Rawg.Mapper
{
    public class RawgGameStoreDtoToViewModelMapper : Profile
    {
        public RawgGameStoreDtoToViewModelMapper()
        {
            CreateMap<RawgGameStoreDto, RawgGameStoreViewModel>();
            CreateMap<RawgGamesResultDto<RawgGameStoreDto>, RawgGamesResultViewModel<RawgGameStoreViewModel>>();
        }
    }
}