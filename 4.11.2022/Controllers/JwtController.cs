using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Project.Controller;

[ApiController]
[Route("api/[controller]")]
public class JwtController : ControllerBase
{
    // [Authorize]
    [HttpGet]
    public IActionResult GetData() => Ok(User.FindFirst(ClaimTypes.Name)?.Value);

    [HttpPost]
    public IActionResult Register([FromForm]string name) 
    {
        var keyByte = System.Text.Encoding.UTF8.GetBytes("sasfdfffffffffffffffffffffadasdqw3884nfojdaklmo08-");
        var securityKey = new SigningCredentials(new SymmetricSecurityKey(keyByte), SecurityAlgorithms.HmacSha256);
        var security = new JwtSecurityToken(
            issuer: "Project1",
            audience:"Project",
            new Claim[]
            {
                new Claim(ClaimTypes.Name, name)
            },
            expires: DateTime.Now.AddMinutes(20),
            signingCredentials: securityKey
        );
        var token = new JwtSecurityTokenHandler().WriteToken(security);
        
        return Ok(token);
    } 
}