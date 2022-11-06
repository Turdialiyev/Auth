using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using Project.Models;
using Project.Services;
using System.Security.Claims;

namespace Project.Filters;

public class AuthenticationAttribute : IActionFilter
{
    private StoreDic _service;

    public string Roles { get; set; }

    public AuthenticationAttribute(StoreDic service, string roles)
    {
        _service = service;
        Roles = roles;
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.HttpContext.Request.Headers.ContainsKey(HeaderNames.Authorization))
        {
            context.Result = new UnauthorizedResult();
            return;
        }

        var authorization = context.HttpContext.Request.Headers[HeaderNames.Authorization];

        if (!_service.Users!.ContainsKey(authorization))
        {
            context.Result = new UnauthorizedResult();
            return;
        }

        var user = _service.Users[authorization];

        if (!Roles.Contains(user.Role!))
        {
            context.Result = new JsonResult(new { Error = "Access denied" });
            return;
        }

        var claims = new List<Claim>()
        {
            new Claim(ClaimTypes.Email, user.Email!),
            new Claim(ClaimTypes.Role, user.Role!),
            new Claim(ClaimTypes.Name, user.Name!)
        };

        var identity = new ClaimsIdentity(claims);

        var principal = new ClaimsPrincipal(identity);

        context.HttpContext.User = principal;
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {

    }
}