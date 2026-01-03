using MongoDB.Driver;

namespace AuthManager.Authorization.Stores.Mongo;

public class MongoStoreBase : IStore
{
    private readonly IMongoClient _client;
    private readonly string _database;

    public MongoStoreBase(string connectionString, string database)
    {
        _client = new MongoClient(connectionString);
        _database = database;
    }

    public Task Add<T>(T document)
    {
        var collection = GetCollection<T>(nameof(T));
        return collection.InsertOneAsync(document);
    }

    public Task Delete<T>(FilterDefinition<T> filter)
    {
        var collection = GetCollection<T>(nameof(T));
        return collection.DeleteOneAsync(filter);
    }

    public async Task<T> GetAsync<T>(FilterDefinition<T> filter)
    {
        var collection = GetCollection<T>(nameof(T));
        var result = await collection.FindAsync<T>(filter);
        return result.FirstOrDefault(); 
    }

    public async Task<List<T>> GetAllAsync<T>(FilterDefinition<T> filter)
    {
        var collection = GetCollection<T>(nameof(T));
        var result = await collection.FindAsync<T>(filter);
        return result.ToList();
    }

    public async Task UpdateAsync<T>(FilterDefinition<T> filter, T replacement)
    {
        var collection = GetCollection<T>(nameof(T));
        await collection.ReplaceOneAsync(filter, replacement);
    }

    private IMongoCollection<T> GetCollection<T>(string collectionName)
    {
        return _client.GetDatabase(_database).GetCollection<T>(collectionName);
    }
}