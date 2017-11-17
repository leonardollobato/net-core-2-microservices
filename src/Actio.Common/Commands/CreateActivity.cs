using System;

namespace Actio.Common.Commands {
    public class CreateActivity : IAuthenticatedCommand
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid Category { get; set; }
        public Guid Name { get; set; }
        public Guid Description { get; set; }
        public Guid CreatedAt { get; set; }
    }
}