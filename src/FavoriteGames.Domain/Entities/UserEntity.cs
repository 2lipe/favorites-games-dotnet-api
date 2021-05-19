using System;
using FavoriteGames.Domain.Dtos.User;
using Optsol.Components.Domain.Entities;

namespace FavoriteGames.Domain.Entities
{
    public class UserEntity : AggregateRoot, IDeletable
    {
        public string Name { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Salt { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime? CreatedDate { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
        public DateTime? DeletedDate { get; private set; }
        
        public UserEntity(CreateUserDto data)
        {
            Name = data.Name;
            UserName = data.UserName;
            Email = data.Email;
            Password = data.Password;
            CreatedDate = DateTime.Now;
        }

        public void Update(UpdateUserDto data)
        {
            Name = data.Name;
            UserName = data.UserName;
            Email = data.Email;
            Password = data.Password;
            UpdatedDate = DateTime.Now;
        }
        
        public void Delete()
        {
            IsDeleted = true;
            DeletedDate = DateTime.Now;
        }
    }
    
}