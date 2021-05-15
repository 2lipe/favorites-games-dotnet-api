using System.Collections.Generic;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgGamesResultViewModel<T>
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<T> Results { get; set; }  
    }
}