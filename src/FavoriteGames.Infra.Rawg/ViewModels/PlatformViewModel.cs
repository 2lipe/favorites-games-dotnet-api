using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class PlatformViewModel : BaseDataTransferObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int GamesCount { get; set; }
        
        public override void Validate()
        {
        }
    }
}