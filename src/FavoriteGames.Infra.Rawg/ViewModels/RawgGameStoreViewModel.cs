using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgGameStoreViewModel : BaseDataTransferObject
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int StoreId { get; set; }
        public string Url { get; set; }   
       
        public override void Validate()
        {
        }
    }
}