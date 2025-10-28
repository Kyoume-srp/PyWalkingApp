using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PYWalkingApp.Models;

public class Pin
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;

    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public List<string> Photos { get; set; } = new();
    public List<string> Tracks { get; set; } = new();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}