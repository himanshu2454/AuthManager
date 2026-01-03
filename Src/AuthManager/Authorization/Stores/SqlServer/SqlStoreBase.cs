using AuthManager.Models;
using MongoDB.Driver;

namespace AuthManager.Authorization.Stores.SqlServer;

public class SqlStoreBase : IStore
{
    public Task Add<T>(T entity)
    {
        throw new NotImplementedException();
    }

    public Task Delete<T>(FilterDefinition<T> filter)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> GetAllAsync<T>(FilterDefinition<T> filter)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetAsync<T>(FilterDefinition<T> filter)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync<T>(FilterDefinition<T> filter, T replacement)
    {
        throw new NotImplementedException();
    }
}
