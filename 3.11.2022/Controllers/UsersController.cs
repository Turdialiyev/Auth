using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Project.Models;
using Project.Filters;
using Project.Services;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;

namespace Project.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly StoreDic _dictionary;
    private readonly string? _service;

    public UsersController(StoreDic dictionary, IOptions<IOptionService> service)
    {
        _dictionary = dictionary;
        _service = service.Value.Path ?? "Users.json";
    }

    [HttpGet]
    [Role("userrole,admin")]
    public IActionResult GetMe()
    {
        Claim? email = User.Claims
            .FirstOrDefault(claim => claim.Type == ClaimTypes.Email);

        return Ok("email: " + email?.Value);
    }

    [HttpPost]
    public IActionResult Reguster(User user)
    {
        var key = Guid.NewGuid().ToString();

        var model = new List<User>();
        string? jsonFile = System.IO.File.ReadAllText(_service!) ?? string.Empty;
        var userData = JsonConvert.DeserializeObject<List<User>>(jsonFile);
        model.Add(user);

        if (jsonFile is null)
        {
            using (var stream = new StreamWriter(_service!))
            {
                stream.Write(JsonConvert.SerializeObject(model));
            }
        }
        else
        {
            userData!.Add(user);

            using (var stream = new StreamWriter(_service!))
            {
                stream.Write(JsonConvert.SerializeObject(userData));
            }
        }

        return Ok(key);
    }
}