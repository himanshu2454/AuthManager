using AuthManager.Authorization;
using AuthManager.Authorization.Stores;
using AuthManager.Authorization.Stores.Mongo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthManager.Strategies.AuthorizationStrategies
{
    public static class RbacAuthorizationStrategy
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IStore, MongoStoreBase>();
            services.AddScoped<IAuthorizationManager, AuthorizationManager>();
        }
    }
}
