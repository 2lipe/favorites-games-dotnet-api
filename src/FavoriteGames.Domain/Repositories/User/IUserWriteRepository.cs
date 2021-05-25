using System;
using FavoriteGames.Domain.Entities;
using Optsol.Components.Domain.Data;

namespace FavoriteGames.Domain.Repositories.User
{
    public interface IUserWriteRepository : IWriteRepository<UserEntity, Guid>
    {
    }
}