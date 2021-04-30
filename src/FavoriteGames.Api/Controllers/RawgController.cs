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

        [HttpGet("api/v1/rawg")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetAllGames()
        {
            var games = await _rawgService.GetAllGames();

            return Ok(games);
        }
    }
}