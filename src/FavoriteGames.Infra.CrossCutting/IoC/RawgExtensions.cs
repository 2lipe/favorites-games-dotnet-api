using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FavoriteGames.Infra.Rawg.Settings;

namespace FavoriteGames.Infra.CrossCutting.IoC
{
    public static class RawgExtensions
    {
        public static IServiceCollection AddRawg(this IServiceCollection services, IConfiguration configuration)
        {
            var rawgSettings = configuration.GetSection(nameof(RawgSettings)).Get<RawgSettings>();
            rawgSettings.Validate();

            services.AddSingleton(rawgSettings);

            return services;
        }
    }
}