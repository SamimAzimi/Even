using System.Diagnostics;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using collection.Models;

namespace collection.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {


        return View();

    }
    public IActionResult Show()
    {
        int[] arr = Enumerable.Range(1, 100).ToArray();
        return View(arr);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
