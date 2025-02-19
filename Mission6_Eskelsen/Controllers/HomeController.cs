using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        ViewBag.categories = _context.Categories.ToList();
        return View(new MovieEntry());
    }

    // posts the response in the add movies form to database
    // navigates to success page
    [HttpPost]
    public IActionResult AddMovies(MovieEntry response)
    {
        if (ModelState.IsValid)
        {
            // adds to db and saves changes
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("EntryConfirmation", response);
        }
        else
        {
            ViewBag.categories = _context.Categories.ToList();
            return View(response);
        }
        
        
        
    }

    // opens the about view
    public IActionResult About()
    {
        return View();
    }

    public IActionResult MoviesList()
    {
        var movies = _context.Movies.Include(x => x.Category)
            .OrderBy(x => x.Title).ToList();
        return View(movies);
    }
    
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var recordToEdit = _context.Movies
            .Single(x => x.MovieId == id);
        
        ViewBag.categories = _context.Categories.ToList();
        return View("AddMovies", recordToEdit);
    }

    [HttpPost]
    public IActionResult Edit(MovieEntry response)
    {
        _context.Movies.Update(response);
        _context.SaveChanges();
        return RedirectToAction("MoviesList");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var recordToDelete = _context.Movies
            .Single(x => x.MovieId == id);
        return View(recordToDelete);
    }

    [HttpPost]
    public IActionResult Delete(MovieEntry recordToDelete)
    {
        _context.Movies.Remove(recordToDelete);
        _context.SaveChanges();
        return RedirectToAction("MoviesList");
    }
    
}