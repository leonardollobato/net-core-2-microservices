using System;

namespace Actio.Common.Events {
    public class ActivityCreated : IAuthenticatedEvent {
        public Guid Id { get; }
        public Guid UserId { get; }
        public Guid Category { get; }
        public Guid Name { get; }
        public Guid Description { get; }
        public Guid CreatedAt { get; }

        protected ActivityCreated () {

        }
        public ActivityCreated (Guid id, Guid userId, Guid category, Guid name, Guid description, Guid createdAt) {
            this.Id = id;
            this.UserId = userId;
            this.Category = category;
            this.Name = name;
            this.Description = description;
            this.CreatedAt = createdAt;

        }

    }
}