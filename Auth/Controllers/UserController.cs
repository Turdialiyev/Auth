using System.Security.Claims;
using Auth.Authentication;
using Auth.Data;
using Auth.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Auth.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly AppDbContext _context;
    private readonly IMemoryCache _memoryCache;

    public UserController(ILogger<UserController> logger, AppDbContext context, IMemoryCache memoryCache)
    {
        _logger = logger;
        _context = context;
        _memoryCache = memoryCache;
    }

    [HttpGet("data")]
    [TypeFilter(typeof(AuthFilterAttribute))]
    public IActionResult Claculate([FromQuery] int nNumber, [FromQuery] int kNumber)
    {
        int replace = 0;
        if (nNumber > kNumber)
        {
            for (int i = 1; i <= nNumber; i++)
            {
                string str = i.ToString();

                if (str.Length >= kNumber.ToString().Length)
                {
                    for (int j = 0; j <= str.Length-kNumber.ToString().Length; j++)
                    {
                        if (str.Substring(j, kNumber.ToString().Length) == kNumber.ToString())
                        {
                            replace += 1;
                        }
                    }
                }
                
            }
        }
        if (nNumber == kNumber)
            replace += 1;


        return Ok(replace);
    }

    [HttpPost]
    public IActionResult UserRegister([FromForm] string userName, [FromForm] string password)
    {
        if (_context.Users!.FirstOrDefault(u => u.UserName == userName) is not null)
            return Ok("This user already exist");

        var model = new User()
        {
            UserName = userName,
            Password = password
        };

        _context.Users!.Add(model);
        _context.SaveChanges();
        var key = Guid.NewGuid().ToString();

        var cacheEntryOption = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(1000));
        _memoryCache.Set("Key", key, cacheEntryOption);

        return Ok("Success Register");
    }
    [HttpPost("Login")]
    public IActionResult Login([FromForm] string userName, [FromForm] string password)
    {

        var userExist = _context.Users!.FirstOrDefault(u => (u.UserName == userName) && (u.Password == password));
        if (userExist is not null)
        {
            var key = Guid.NewGuid().ToString();
            var cacheEntryOption = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(1000));
            _memoryCache.Set("Key", key, cacheEntryOption);
            return Ok("Success Login");
        }
        return Unauthorized();
    }
}
