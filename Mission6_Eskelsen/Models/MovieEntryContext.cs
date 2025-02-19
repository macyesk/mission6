using Microsoft.EntityFrameworkCore;

namespace Mission6_Eskelsen.Models;

public class MovieEntryContext :DbContext
{
    public MovieEntryContext(DbContextOptions<MovieEntryContext> options) : base(options)
    {
        
    }

    // creates table called Movies
    public DbSet<MovieEntry> Movies { get; set; }
    
    public DbSet<Category> Categories { get; set; }
 
}