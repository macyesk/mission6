using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_Eskelsen.Models;

namespace Mission6_Eskelsen.Controllers;

public class HomeController : Controller
{
    // creates the database globally
    private MovieEntryContext _context;
    
    // creates an instance of the database on open
    public HomeController(MovieEntryContext temp)
    {
        _context = temp;
    }

    // opens the index view
    public IActionResult Index()
    {
        return View();
    }

    // opens the add movie view
    [HttpGet]
    public IActionResult AddMovies()
    {
        return View();
    }

    // posts the response in the add movies form to database
    // navigates to success page
    [HttpPost]
    public IActionResult AddMovies(MovieEntry response)
    {
        // adds to db and saves changes
        _context.Movies.Add(response);
        _context.SaveChanges();
        return View("EntryConfirmation", response);
    }

    // opens the about view
    public IActionResult About()
    {
        return View();
    }
   
}