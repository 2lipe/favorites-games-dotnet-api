namespace FavoriteGames.Infra.Rawg.ViewModels
{
    public class RawgMetacritcPlatformViewModel
    {
        public int Metascore { get; set; }
        public string Url { get; set; } 
        public MetacriticPlatformViewModel Platform { get; set; }
    }
    
    public class MetacriticPlatformViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }  
}