namespace AuthManager
{
    public interface IAuthManagerOptions
    {
        AuthManagerOptions AddAuthentication(Type type);
        AuthManagerOptions AddAuthorization(Type type);
    }
}
