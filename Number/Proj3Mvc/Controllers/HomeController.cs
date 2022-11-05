using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proj3Mvc.Models;

namespace Proj3Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ConvertService _convertService;

    public HomeController(ILogger<HomeController> logger, ConvertService convertService)
    {
        _logger = logger;
        _convertService = convertService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult SonKiritish()
    {
        return View();
    }
    [HttpPost]
    public IActionResult SonKiritish(SonViewModel model)
    {
        var str = _convertService.FromNumberToWords(model.Number);
        ViewBag.x = str;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
