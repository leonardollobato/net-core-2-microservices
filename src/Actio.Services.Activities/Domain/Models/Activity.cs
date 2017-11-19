using System;

namespace Actio.Services.Activities.Domain.Models
{
    public class Activity
    {
         public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Category { get; protected set; }
        public string Description { get; protected set; }
        public Guid UserId { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        public Activity()
        {
            
        }

        public Activity(Guid id, string name, string category, string description, Guid userId, DateTime createdAt)
        {
            this.Id = id;
            this.Name = name.ToLowerInvariant();
            this.Category = category;
            this.Description = description;
            this.UserId = userId;
            this.CreatedAt = createdAt;
        }
    }
}