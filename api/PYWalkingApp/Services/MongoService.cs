using MongoDB.Driver;

namespace PYWalkingApp.Services;

public class MongoService
{
    private readonly IMongoDatabase _database;

    public MongoService(IConfiguration config)
    {
        var connectionString = config["MONGO_CONNECTION"];
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase("pywalkingapp");
    }

    public IMongoCollection<T> GetCollection<T>(string name) => _database.GetCollection<T>(name);
}