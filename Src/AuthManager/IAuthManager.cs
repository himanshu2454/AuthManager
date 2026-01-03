using AuthManager.Strategies;

namespace AuthManager
{
    public interface IAuthManager
    {
        AuthManager AddAuthentication<T>() where T : IAuthenticationStrategy;
        AuthManager AddAuthorization<T>() where T : IAuthorizationStrategy;
    }
}
