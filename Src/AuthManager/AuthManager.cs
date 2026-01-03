using AuthManager.Authentication;
using AuthManager.Authorization;

namespace AuthManager;

public interface IAuthManager
{
}

public class AuthorizationManager : IAuthManager
{
    private readonly IAuthenticationStrategy _authn;
    private readonly IAuthorizationStrategy _authz;

    public AuthorizationManager(IAuthenticationStrategy authnStrategy, IAuthorizationStrategy authzStrategy)
    {
        _authn = authnStrategy;
        _authz = authzStrategy;
    }
}