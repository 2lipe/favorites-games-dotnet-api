using System;
using FavoriteGames.Shared.Helpers;

namespace FavoriteGames.Infra.Rawg.Settings
{
    public class RawgSettings
    {
        public string Url { get; set; }
        
        public string Key { get; set; }

        public void Validate()
        {
            ValidateHelper.IsNullOrEmptyStringValidate(Url);
            ValidateHelper.IsNullOrEmptyStringValidate(Key);

            var endsWithBarInUrl = Url.EndsWith("/");
            if (endsWithBarInUrl)
            {
                throw new FormatException($"{nameof(Url)} must not end with '/'");
            }
        }
    }
}