using Microsoft.EntityFrameworkCore;

namespace Mission6_Eskelsen.Models;

public class MovieEntryContext :DbContext
{
    public MovieEntryContext(DbContextOptions<MovieEntryContext> options) : base(options)
    {
        
    }

    public DbSet<MovieEntry> Movies { get; set; }
 
}