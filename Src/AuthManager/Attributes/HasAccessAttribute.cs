using Microsoft.AspNetCore.Authorization;

namespace AuthManager.Attributes;

public class HasAccessAttribute(string policy) : AuthorizeAttribute(policy)
{
}
