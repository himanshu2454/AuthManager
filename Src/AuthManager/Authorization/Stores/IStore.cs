using MongoDB.Driver;

namespace AuthManager.Authorization.Stores;

public interface IStore
{
    Task Add<T>(T entity);
    Task Delete<T>(FilterDefinition<T> filter);
    Task<T> GetAsync<T>(FilterDefinition<T> filter);
    Task<List<T>> GetAllAsync<T>(FilterDefinition<T> filter);
    Task UpdateAsync<T>(FilterDefinition<T> filter, T replacement);
}