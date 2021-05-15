using System;
using System.Threading.Tasks;
using AutoMapper;
using FavoriteGames.Infra.Rawg.Client;
using FavoriteGames.Infra.Rawg.Exceptions;
using FavoriteGames.Infra.Rawg.Settings;
using FavoriteGames.Infra.Rawg.ViewModels;

namespace FavoriteGames.Infra.Rawg.Services
{
    public class RawgService : IRawgService
    {
        private RawgSettings _rawgSettings;
        private readonly RawgClient _rawgClient;
        private readonly IMapper _mapper;

        public RawgService(RawgClient rawgClient, IMapper mapper, RawgSettings rawgSettings)
        {
            _rawgSettings = rawgSettings;
            _rawgClient = rawgClient;
            _mapper = mapper;
        }

        public async Task<RawgGamesResultViewModel<RawgGamesViewModel>> GetAllGamesAsync()
        {
            try
            {
                var rawgGamesDto = await _rawgClient.GetRawgGames(_rawgSettings.Key, "100");

                var rawgGamesVm = _mapper.Map<RawgGamesResultViewModel<RawgGamesViewModel>>(rawgGamesDto);

                return rawgGamesVm;
            }
            catch (Exception e)
            {
                throw new RawgException(e.Message);
            }
        }
    }
}