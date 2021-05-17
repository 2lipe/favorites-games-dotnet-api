using System.Collections.Generic;
using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgGamesResultViewModel<T> : BaseDataTransferObject
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<T> Results { get; set; }
        
        public override void Validate()
        {
        }
    }
}