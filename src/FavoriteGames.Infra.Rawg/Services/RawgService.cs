using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FavoriteGames.Infra.Rawg.Client;
using FavoriteGames.Infra.Rawg.Exceptions;
using FavoriteGames.Infra.Rawg.Settings;
using FavoriteGames.Infra.Rawg.ViewModels;
using Microsoft.Extensions.Configuration;

namespace FavoriteGames.Infra.Rawg.Services
{
    public class RawgService : IRawgService
    {
        private readonly RawgClient _rawgClient;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public RawgService(RawgClient rawgClient, IConfiguration configuration, IMapper mapper)
        {
            _rawgClient = rawgClient;
            _configuration = configuration;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RawgGamesViewModel>> GetAllGames()
        {
            try
            {
                var rawgSettings = _configuration.GetSection(nameof(RawgSettings)).Get<RawgSettings>();
                var rawgGames = await _rawgClient.GetRawgGames(rawgSettings.Key, "100");

                var rawgGamesModel = _mapper.Map<IEnumerable<RawgGamesViewModel>>(rawgGames.Results);

                return rawgGamesModel;
            }
            catch (Exception e)
            {
                throw new RawgException(e.Message);
            }
        }
    }
}