using System.Threading.Tasks;
using FavoriteGames.Infra.Rawg.ViewModels;

namespace FavoriteGames.Infra.Rawg.Services
{
    public interface IRawgService
    {
        Task<RawgGamesResultViewModel<RawgGamesViewModel>> GetAllGamesAsync();
        Task<RawgGamesDetailsViewModel> GetGameByIdAsync(string id);
    }
}