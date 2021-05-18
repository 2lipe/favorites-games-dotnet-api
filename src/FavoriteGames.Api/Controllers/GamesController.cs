using System.Threading.Tasks;
using FavoriteGames.Infra.Rawg.Services;
using Microsoft.AspNetCore.Mvc;
using Optsol.Components.Service.Responses;

namespace FavoriteGames.Api.Controllers
{
    public class GamesController : BaseController
    {
        private readonly IRawgService _rawgService;
        
        public GamesController(IResponseFactory responseFactory, IRawgService rawgService) : base(responseFactory)
        {
            _rawgService = rawgService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetAllGames()
        {
            var games = await _rawgService.GetAllGamesAsync();

            return CreateResult(games);
        }
        
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetGameById([FromRoute] string id)
        {
            var game = await _rawgService.GetGameByIdAsync(id);

            return CreateResult(game);
        }
        
        [HttpGet("{id}/trailers")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetGameTrailerById([FromRoute] string id)
        {
            var trailer = await _rawgService.GetGameTrailersByIdAsync(id);

            return CreateResult(trailer);
        }
        
        [HttpGet("{id}/dlcs")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetGameDlcsById([FromRoute] string id)
        {
            var dlcs = await _rawgService.GetGameDlcsByIdAsync(id);

            return CreateResult(dlcs);
        }
    }
}