using System;
using FavoriteGames.Infra.Rawg.Client;
using FavoriteGames.Infra.Rawg.Mapper;
using FavoriteGames.Infra.Rawg.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FavoriteGames.Infra.Rawg.Settings;
using Refit;

namespace FavoriteGames.Infra.CrossCutting.IoC
{
    public static class RawgExtensions
    {
        public static IServiceCollection AddRawg(this IServiceCollection services, IConfiguration configuration)
        {
            var rawgSettings = configuration.GetSection(nameof(RawgSettings)).Get<RawgSettings>();
            rawgSettings.Validate();

            services.AddSingleton(rawgSettings);
            
            services.AddScoped<IRawgService, RawgService>();

            services
                .AddAutoMapper(typeof(RawgGamesDtoToViewModelMapper))
                .AddAutoMapper(typeof(RawgGameDetailsDtoToViewModelMapper));

            services
                .AddRefitClient<RawgClient>()
                .ConfigureHttpClient(client => client.BaseAddress = new Uri($"{rawgSettings.Url}"));
            
            return services;
        }
    }
}