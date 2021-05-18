using System.Threading.Tasks;
using FavoriteGames.Infra.Rawg.Dtos;
using Refit;

namespace FavoriteGames.Infra.Rawg.Client
{
    public interface RawgClient
    {
        [Get("/games?key={key}&page_size{pageSize}")]
        [Headers("Authorization: Basic", "Content-Type: application/x-www-form-urlencoded")]
        Task<RawgGamesResultDto<RawgGamesDto>> GetRawgGames([Query] string key, [Query] string pageSize);

        [Get("/games/{id}?key={key}")]
        [Headers("Authorization: Basic", "Content-Type: application/x-www-form-urlencoded")]
        Task<RawgGameDetailsDto> GetRawgGameDetails([Query] string id, [Query] string key);
        
        [Get("/games/{id}/movies?key={key}")]
        [Headers("Authorization: Basic", "Content-Type: application/x-www-form-urlencoded")]
        Task<RawgGamesResultDto<RawgGameTrailersDto>> GetRawgGameTrailers([Query] string id, [Query] string key);
        
        [Get("/games/{id}/additions?key={key}")]
        [Headers("Authorization: Basic", "Content-Type: application/x-www-form-urlencoded")]
        Task<RawgGamesResultDto<RawgGamesDto>> GetRawgGameDlcs([Query] string id, [Query] string key);
    }
}