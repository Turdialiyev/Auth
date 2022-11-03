using Auth.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;

namespace Auth.Authentication;

public class AuthFilterAttribute : ActionFilterAttribute
{
    private readonly AppDbContext _context;
    private readonly IMemoryCache _memoryCash;

    public AuthFilterAttribute(AppDbContext context, IMemoryCache memoryCache )
    {
        _context = context;
        _memoryCash = memoryCache;
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var key =  _memoryCash.Get("Key");
        if (key == null )
        {
            context.Result = new UnauthorizedResult();
            return;
        }
    }
}