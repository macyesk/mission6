using System.ComponentModel.DataAnnotations;

namespace Mission6_Eskelsen.Models;

// sets up the requirements for each entry in the movies table
public class MovieEntry
{
    // sets up a primary key called movieid
    [Key]
    [Required]
    public int movieId { get; set; }
    
    [Required]
    public string title { get; set; }
    
    [Required]
    public string year { get; set; }
    
    [Required]
    public string director { get; set; }
    
    [Required]
    public string rating { get; set; }
    
    [Required]
    public string category { get; set; }
    
    // a boolean for edited value
    public bool edited { get; set; }
   
    // allows for lentto value to be null
    public string? lentto { get; set; }
   
    // allows for notes value to be null
    public string? notes { get; set; }
    
}