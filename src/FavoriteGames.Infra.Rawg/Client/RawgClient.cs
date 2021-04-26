using System.Threading.Tasks;
using FavoriteGames.Infra.Rawg.Dtos;
using Refit;

namespace FavoriteGames.Infra.Rawg.Client
{
    public interface RawgClient
    {
        [Get("/games{key}&page_size{pageSize}")]
        [Headers("Authorization: Basic", "Content-Type: application/x-www-form-urlencoded")]
        Task<RawgGamesResultDto<RawgGamesDto>> GetRawgGames([Query] string key, [Query] string pageSize);
    }
}