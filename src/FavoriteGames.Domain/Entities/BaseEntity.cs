using System;

namespace FavoriteGames.Domain.Entities
{
    public abstract class BaseEntity : IEquatable<BaseEntity>
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; set; }
        
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }
        
        public bool Equals(BaseEntity other)
        {
            return other != null && Id == other.Id;
        }
    }
}