using System;
using FavoriteGames.Domain.Entities;
using FavoriteGames.Domain.Repositories.User;
using Microsoft.Extensions.Logging;
using Optsol.Components.Infra.Data;

namespace FavoriteGames.Infra.Data.Repositories.User
{
    public class UserReadRepository : Repository<UserEntity, Guid>, IUserReadRepository
    {
        public UserReadRepository(CoreContext context, ILoggerFactory logger) : base(context, logger)
        {
        }
    }
}