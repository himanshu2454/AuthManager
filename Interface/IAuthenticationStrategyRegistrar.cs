using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthManager.Interface
{
    public interface IAuthenticationStrategyRegistrar
    {
        void Register(IServiceCollection services, IConfiguration configuration);
    }
}