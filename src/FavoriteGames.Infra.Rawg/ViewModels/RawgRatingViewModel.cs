using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgRatingViewModel : BaseDataTransferObject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
        
        public override void Validate()
        {
        }
    }
}