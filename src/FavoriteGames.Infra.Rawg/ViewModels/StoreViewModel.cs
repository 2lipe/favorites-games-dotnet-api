using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class StoreViewModel : BaseDataTransferObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Domain { get; set; }
        public int GamesCount { get; set; }
        
        public override void Validate()
        {
        }
    }
}