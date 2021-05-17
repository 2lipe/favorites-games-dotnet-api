using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgPlatformViewModel : BaseDataTransferObject
    {
        public PlatformViewModel Platform { get; set; }
        public string ReleasedAt { get; set; }
        public RequirementsViewModel RequirementsEn { get; set; }
        
        public override void Validate()
        {
        }
    }
}