using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgMetacritcPlatformViewModel : BaseDataTransferObject
    {
        public int Metascore { get; set; }
        public string Url { get; set; } 
        public MetacriticPlatformViewModel Platform { get; set; }
        
        public override void Validate()
        {
        }
    }
    
    public class MetacriticPlatformViewModel : BaseDataTransferObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        
        public override void Validate()
        {
        }
    }  
}