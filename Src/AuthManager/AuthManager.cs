using AuthManager.Strategies;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthManager;

public class AuthManager : IAuthManager
{
    internal Action<IServiceCollection, IConfiguration>? RegisterStrategyServices { get; private set; }

    public AuthManager AddAuthentication<T>() where T : IAuthenticationStrategy
    {
        RegisterStrategyServices += (services, config) => T.Register(services, config);
        return this;
    }

    public AuthManager AddAuthorization<T>() where T : IAuthorizationStrategy
    {
        RegisterStrategyServices += (services, config) => T.Register(services, config);
        return this;
    }
}