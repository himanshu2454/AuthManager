using AuthManager.Interface;

namespace AuthManager.Models
{
    public class AuthManagerOptions
    {
        public string Schema { get; set; } = string.Empty;
        public string? AuthStrategy { get; set; }
        public Func<string, string, Task<string?>>? GetUserRoleFunc { get; set; }
    }
}
