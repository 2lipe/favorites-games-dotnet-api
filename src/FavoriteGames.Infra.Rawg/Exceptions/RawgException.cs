using System;

namespace FavoriteGames.Infra.Rawg.Exceptions
{
    public class RawgException : Exception
    {
        public RawgException(string message) : base(message)
        {
        }
    }
}