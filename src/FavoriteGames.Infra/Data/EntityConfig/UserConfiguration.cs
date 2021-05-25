using System;
using FavoriteGames.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optsol.Components.Infra.Data;

namespace FavoriteGames.Infra.Data.EntityConfig
{
    public class UserConfiguration : EntityConfigurationBase<UserEntity, Guid>
    {
        public override void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users");

            builder.Property(entity => entity.Email)
                .IsRequired();
            
            builder.Property(entity => entity.UserName)
                .IsRequired()
                .HasMaxLength(50);
            
            builder.Property(entity => entity.Name)
                .HasMaxLength(200);

            builder.Property(entity => entity.Password)
                .IsRequired()
                .HasMaxLength(50);
            
            base.Configure(builder);
        }
    }
}