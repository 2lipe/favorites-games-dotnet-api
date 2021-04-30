using System.Collections.Generic;
using System.Threading.Tasks;
using FavoriteGames.Infra.Rawg.ViewModels;

namespace FavoriteGames.Infra.Rawg.Services
{
    public interface IRawgService
    {
        Task<IEnumerable<RawgGamesViewModel>> GetAllGames();
    }
}