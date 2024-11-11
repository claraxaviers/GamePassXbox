using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GamePassXbox.Data
{
    public class Usuario
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("senha")]
        public string Senha { get; set; }
    }
}
