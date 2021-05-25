using Microsoft.EntityFrameworkCore;
using Optsol.Components.Infra.Data;

namespace FavoriteGames.Infra.Data.Context
{
    public class UserContext : CoreContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}