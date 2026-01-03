using Microsoft.Extensions.DependencyInjection;

namespace AuthManager
{
    public static class AuthManagerServiceCollectionExtensions
    {
        public static IServiceCollection AddAuthManager(this IServiceCollection services, Action<IAuthManagerOptions> configureAction)
        {
            if (configureAction == null) throw new ArgumentNullException(nameof(configureAction));

            var options = new AuthManagerOptions();
            configureAction(options);
            options.RegisterStrategyServices?.Invoke(services);
            //services.AddScoped<IAuthManager, AuthManager>();
            return services;
        }
    }
}
