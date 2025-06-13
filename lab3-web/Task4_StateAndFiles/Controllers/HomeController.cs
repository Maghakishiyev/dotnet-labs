using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using Task4_StateAndFiles.Models;

namespace Task4_StateAndFiles.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult SetData()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SetData(string userName, string greeting)
    {
        if (!string.IsNullOrEmpty(userName))
        {
            Response.Cookies.Append(
                "UserName",
                userName,
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddMinutes(30) }
            );
        }

        if (!string.IsNullOrEmpty(greeting))
        {
            HttpContext.Session.SetString("Greeting", greeting);
        }

        return RedirectToAction("GetData");
    }

    public IActionResult GetData()
    {
        ViewBag.Name = Request.Cookies["UserName"];
        ViewBag.Message = HttpContext.Session.GetString("Greeting");
        return View();
    }

    public IActionResult WriteFile()
    {
        var filePath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "wwwroot",
            "data.txt"
        );

        System.IO.File.WriteAllText(
            filePath,
            $"Saved at: {DateTime.Now:O}"
        );

        return Content($"File written to: {filePath}");
    }

    public IActionResult SetColor()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SetColor(string favoriteColor)
    {
        if (!string.IsNullOrEmpty(favoriteColor))
        {
            Response.Cookies.Append(
                "FavoriteColor",
                favoriteColor,
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddMinutes(30) }
            );
        }

        return RedirectToAction("GetColor");
    }

    public IActionResult GetColor()
    {
        ViewBag.Color = Request.Cookies["FavoriteColor"];
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
