using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using Json.Models;
using Microsoft.AspNetCore.Mvc;

namespace Json.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get([FromQuery] int aNumber, [FromQuery] int bNumber)
    {
        int sum = 0;
        if (aNumber >= bNumber)
        {
            for (int i = bNumber; i <= aNumber; i++)
            {
                sum += i;
            }
        }
        if (aNumber <= bNumber)
        {
            for (int i = aNumber; i <= bNumber; i++)
            {
                sum += i;
            }
        }

        var model = new Log()
        {
            Anumber = aNumber,
            Bnumber = bNumber,
            Sum = sum
        };
        var path = Path.Combine(Directory.GetCurrentDirectory(), @"Folders\json.txt");
        string? text = System.IO.File.ReadAllText(path) ?? string.Empty;
        var count = text.Length;
        var json = JsonSerializer.Serialize(model);

        using (var stream = new StreamWriter(path))
        {
            if (text is "")
            {
                stream.Write("[" + json + "]");
            }
            else
            {
                stream.Write(text.Substring(0, count-1) +","+ json + "]");
            }
        }

        return Ok(json);
    }
}
