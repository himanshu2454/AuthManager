using AuthManager.Interface;

namespace AuthManager
{
    public class AuthManager : IAuthManager
    {
        private readonly IAuthenticationStrategy _authn;
        private readonly IAuthorizationStrategy _authz;

        public AuthManager(IAuthenticationStrategy authnStrategy, IAuthorizationStrategy authzStrategy)
        {
            _authn = authnStrategy;
            _authz = authzStrategy;
        }
    }
}