using AuthManager.Core;

namespace AuthManager.Interface
{
    public interface IAuthManagerOptions
    {
        AuthManagerOptions AddAuthentication(Type type);
        AuthManagerOptions AddAuthorization(Type type);
    }
}
