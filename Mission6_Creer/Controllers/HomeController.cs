using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_Creer.Models;

namespace Mission6_Creer.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutJoel()
    {
        return View();
    }

    public IActionResult Movies()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Movies(Movie response)
    {
        return View("Confirmation", response);
    }

}