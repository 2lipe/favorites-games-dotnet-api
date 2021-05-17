using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgGameTrailersViewModel : BaseDataTransferObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Preview { get; set; }
        public TrailerDataViewModel Data { get; set; }
        
        public override void Validate()
        {
        }
    }
    
    public class TrailerDataViewModel : BaseDataTransferObject
    {
        public string _480 { get; set; }
        public string Max { get; set; }
        
        public override void Validate()
        {
        }
    }
}