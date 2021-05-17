using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgShortScreenshotViewModel : BaseDataTransferObject
    {
        public int Id { get; set; }
        public string Image { get; set; }
        
        public override void Validate()
        {
        }
    }
}