using System.Threading.Tasks;
using FavoriteGames.Infra.Rawg.Dtos;

namespace FavoriteGames.Infra.Rawg.Services
{
    public interface IRawgService
    {
        Task<RawgGamesResultDto<RawgGamesDto>> GetAllGames();
    }
}