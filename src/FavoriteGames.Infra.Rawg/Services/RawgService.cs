using System;
using System.Threading.Tasks;
using FavoriteGames.Infra.Rawg.Client;
using FavoriteGames.Infra.Rawg.Dtos;
using FavoriteGames.Infra.Rawg.Exceptions;
using FavoriteGames.Infra.Rawg.Settings;
using Microsoft.Extensions.Configuration;

namespace FavoriteGames.Infra.Rawg.Services
{
    public class RawgService : IRawgService
    {
        private readonly RawgClient _rawgClient;
        private readonly IConfiguration _configuration;

        public RawgService(RawgClient rawgClient, IConfiguration configuration)
        {
            _rawgClient = rawgClient;
            _configuration = configuration;
        }

        public Task<RawgGamesResultDto<RawgGamesDto>> GetAllGames()
        {
            try
            {
                var rawgSettings = _configuration.GetSection(nameof(RawgSettings)).Get<RawgSettings>();
                var rawgGames = _rawgClient.GetRawgGames(rawgSettings.Key, "100");
                
                return rawgGames;
            }
            catch (Exception e)
            {
                throw new RawgException(e.Message);
            }
        }
    }
}