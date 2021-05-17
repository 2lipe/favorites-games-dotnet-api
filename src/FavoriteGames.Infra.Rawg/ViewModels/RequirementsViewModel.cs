using Optsol.Components.Application.DataTransferObjects;

namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RequirementsViewModel : BaseDataTransferObject
    {
        public string Minimum { get; set; }
        public string Recommended { get; set; }
        
        public override void Validate()
        {
        }
    }
}