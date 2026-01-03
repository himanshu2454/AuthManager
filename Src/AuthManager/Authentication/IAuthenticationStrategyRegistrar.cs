using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthManager.Authentication
{
    public interface IAuthenticationStrategyRegistrar
    {
        void Register(IServiceCollection services, IConfiguration configuration);
    }
}