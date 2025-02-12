using System.ComponentModel.DataAnnotations;

namespace Mission6_Eskelsen.Models;

public class MovieEntry
{
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
    
    public bool edited { get; set; }
   
    public string? lentto { get; set; }
   
    public string? notes { get; set; }
    
}