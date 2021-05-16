using System.Threading.Tasks;
using FavoriteGames.Infra.Rawg.Services;
using Microsoft.AspNetCore.Mvc;

namespace FavoriteGames.Api.Controllers
{
    public class RawgController : ControllerBase
    {
        private readonly IRawgService _rawgService;

        public RawgController(IRawgService rawgService)
        {
            _rawgService = rawgService;
        }

        [HttpGet("api/v1/rawg/games")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetAllGames()
        {
            var games = await _rawgService.GetAllGamesAsync();

            return Ok(games);
        }
        
        [HttpGet("api/v1/rawg/games/{id}")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetGameById([FromRoute] string id)
        {
            var game = await _rawgService.GetGameByIdAsync(id);

            return Ok(game);
        }
    }
}