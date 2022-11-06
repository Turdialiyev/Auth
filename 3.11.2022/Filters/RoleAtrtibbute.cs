using Microsoft.AspNetCore.Mvc;

namespace Project.Filters;

public class RoleAttribute : TypeFilterAttribute
{
    public RoleAttribute(string role) : base(typeof(AuthenticationAttribute))
    {
        Arguments = new object[] { role };
    }
}