namespace AuthManager.Models;

public interface IRolesAndPermissions
{
    string Roles { get; set; }
    List<string> Permissions { get; set; }
}

public class RolesAndPermissions : IRolesAndPermissions
{
    public string Roles { get; set; } = string.Empty;
    public List<string> Permissions { get; set; } = [];
}