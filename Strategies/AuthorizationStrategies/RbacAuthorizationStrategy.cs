

using AuthManager.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthManager.Strategies.AuthorizationStrategies
{
    public static class RbacAuthorizationStrategy
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdminRole", policy =>
                    policy.RequireRole("Admin"));

                options.AddPolicy("RequireLoggedInUserRole", policy =>
                    policy.RequireRole("LoggedInUser"));

                options.AddPolicy("CanModerate", policy =>
                    policy.RequireRole("Admin", "Moderator"));
            });
        }
    }
}
