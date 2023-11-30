using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _08_Projeto_MVC.Models;

namespace _08_Projeto_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        ViewData["Message"] = "Testando os Dados da Aplicação";
        ViewData["Email"] = "renan@gmail.com";
        return View();
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
