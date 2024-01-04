using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities
{
    public class BaseEntity
    {
        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public DateTimeOffset CreatedAt { get; private set; } = DateTimeOffset.Now;
        public DateTimeOffset UpdatedAt { get; set; }
        public bool Active { get; set; } = true;
    }
}
