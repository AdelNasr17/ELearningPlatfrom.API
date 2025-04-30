

namespace ELearningPlatfrom.Domain.Entities
{
    public abstract class BaseEntity
    {
        // Unique identifier for the entity, initialized with a new GUID
        public Guid Id { get; set; } = Guid.NewGuid();

        // Timestamp indicating when the field was created, initialized to the current UTC time
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
