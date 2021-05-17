using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgStoreViewModel : BaseDataTransferObject
    {
        public int Id { get; set; }
        public StoreViewModel Store { get; set; }
        
        public override void Validate()
        {
        }
    }
}