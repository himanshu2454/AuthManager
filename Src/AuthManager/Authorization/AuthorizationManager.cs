using AuthManager.Authorization.Stores;
using AuthManager.Models;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;

namespace AuthManager.Authorization;

public interface IAuthorizationManager
{
    Task Seed<T>(List<T> entities);
    Task Add<T>(T entity);
    Task Update<T>(FilterDefinition<T> filter, T replacement);
    Task Delete<T>(FilterDefinition<T> filter);
    Task<List<T>> GetAllAccessPaths<T>(string username) where T : IUserAccess;
}

internal class AuthorizationManager(IStore store, ILogger<AuthorizationManager> logger) : IAuthorizationManager
{
    private readonly IStore _store = store;
    private readonly ILogger<AuthorizationManager> _logger = logger;

    public async Task Seed<T>(List<T> entities)
    {
        var tasks = new List<Task>();
        foreach (var entity in entities)
        {
            tasks.Add(_store.Add(entity));
        }
        await Task.WhenAll(tasks);
    }

    public async Task Add<T>(T entity)
    {
        await _store.Add(entity);
    }

    public async Task Update<T>(FilterDefinition<T> filter, T replacement)
    {
        await _store.UpdateAsync(filter, replacement);
    }

    public async Task Delete<T>(FilterDefinition<T> filter)
    {
        await _store.Delete(filter);
    }

    public async Task<List<T>> GetAllAccessPaths<T>(string username) where T : IUserAccess
    {
        var filter = Builders<T>.Filter.Eq("Username", username);
        var userAccess = await _store.GetAllAsync<T>(filter);
        if (userAccess == null || userAccess.Count == 0)
        {
            _logger.LogWarning("User {Username} not found", username);
            return []; ;
        }
        return userAccess;
    }
}