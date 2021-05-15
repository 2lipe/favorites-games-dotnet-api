namespace FavoriteGames.Shared.Helpers
{
    public class Result<TData>
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public TData Data { get; set; }
        public object Errors { get; set; }
    }
}