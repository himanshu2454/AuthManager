using AuthManager.Strategies.AuthenticationStrategies;
using AuthManager.Strategies.AuthorizationStrategies;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthManager
{
    public class AuthManagerOptions : IAuthManagerOptions
    {
        internal Action<IServiceCollection>? RegisterStrategyServices { get; private set; }

        public AuthManagerOptions AddAuthentication(Type type)
        {
            RegisterStrategyServices += services =>
            {
                switch (type.Name)
                {
                    case "EntraIdAuthenticationStrategy":
                        EntraIdAuthenticationStrategy.Register(services, services.BuildServiceProvider().GetRequiredService<IConfiguration>());
                        break;
                }
            };
            return this;
        }

        public AuthManagerOptions AddAuthorization(Type type)
        {
            RegisterStrategyServices += services =>
            {
                switch (type.Name)
                {
                    case "RbacAuthorizationStrategy":
                        RbacAuthorizationStrategy.Register(services, services.BuildServiceProvider().GetRequiredService<IConfiguration>());
                        break;
                }
            };
            return this;
        }
    }
}
