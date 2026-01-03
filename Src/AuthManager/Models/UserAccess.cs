namespace AuthManager.Models;

public interface IUserAccess
{
    string Username { get; set; }
    string Role { get; set; }
    List<List<string>> AccessPath { get; set; }
}

public class UserAccess : IUserAccess
{
    public string Username { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty ;
    public List<List<string>> AccessPath { get; set; } = [];
}