using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthManager.Strategies;

public interface IAuthenticationStrategy : IAuthStrategy
{
}

public interface IAuthorizationStrategy : IAuthStrategy
{
}

public interface IAuthStrategy
{
    static abstract void Register(IServiceCollection services, IConfiguration configuration);
}