using System;
using FavoriteGames.Domain.Entities;
using FavoriteGames.Domain.Repositories.User;
using Microsoft.Extensions.Logging;
using Optsol.Components.Infra.Data;

namespace FavoriteGames.Infra.Data.Repositories.User
{
    public class UserWriteRepository : Repository<UserEntity, Guid>, IUserWriteRepository
    {
        public UserWriteRepository(CoreContext context, ILoggerFactory logger) : base(context, logger)
        {
        }
    }
}