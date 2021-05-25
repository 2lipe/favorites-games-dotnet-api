using Microsoft.Extensions.DependencyInjection;
using Optsol.Components.Domain.Data;
using Optsol.Components.Infra.Data;

namespace FavoriteGames.Infra.CrossCutting.IoC
{
    public static class RepositoryExtensions
    {
        private static IServiceCollection AddFavoriteGamesRepository(this IServiceCollection services)
        {
            services
                .AddScoped(typeof(IRepository<,>), typeof(Repository<,>))
                .AddScoped(typeof(IReadRepository<,>), typeof(Repository<,>))
                .AddScoped(typeof(IWriteRepository<,>), typeof(Repository<,>));

            services.
            
            return services;
        }
    }
}