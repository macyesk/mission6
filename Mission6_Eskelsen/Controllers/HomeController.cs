using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_Eskelsen.Models;

namespace Mission6_Eskelsen.Controllers;

public class HomeController : Controller
{
    private MovieEntryContext _context;

    public HomeController(MovieEntryContext temp)
    {
        _context = temp;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult AddMovies()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddMovies(MovieEntry response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges();
        return View("EntryConfirmation", response);
    }

    public IActionResult About()
    {
        return View();
    }
   
}