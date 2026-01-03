using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthManager
{
    public static class AuthManagerServiceCollectionExtensions
    {
        public static IServiceCollection AddAuthManager(
            this IServiceCollection services,
            IConfiguration configuration, // Pass config directly
            Action<AuthManager> configureAction)
        {
            var manager = new AuthManager();
            configureAction(manager);

            // Execute all queued registrations using the real configuration
            manager.RegisterStrategyServices?.Invoke(services, configuration);

            return services;
        }
    }
}
