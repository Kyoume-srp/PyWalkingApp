using PYWalkingApp.Models;
using MongoDB.Driver;
using PYWalkingApp.Services;

namespace PYWalkingApp.Repositories;

public class PinRepository
{
    private readonly IMongoCollection<Pin> _pins;

    public PinRepository(MongoService mongoService)
    {
        _pins = mongoService.GetCollection<Pin>("pins");
    }

    public async Task<List<Pin>> GetAllAsync() => await _pins.Find(_ => true).ToListAsync();
    public async Task CreateAsync(Pin pin) => await _pins.InsertOneAsync(pin);
}