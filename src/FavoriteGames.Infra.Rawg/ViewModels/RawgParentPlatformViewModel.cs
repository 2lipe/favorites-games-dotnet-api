using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgParentPlatformViewModel : BaseDataTransferObject
    {
        public PlatformViewModel Platform { get; set; }
        
        public override void Validate()
        {
        }
    }
}