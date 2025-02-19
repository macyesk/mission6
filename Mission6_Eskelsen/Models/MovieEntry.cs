using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Eskelsen.Models;

// sets up the requirements for each entry in the movies table
public class MovieEntry
{
    // sets up a primary key called movieid
    [Key]
    [Required]
    public int MovieId { get; set; }
    
    [Required]
    public string Title { get; set; }
    
    [Required]
    [Range(1888, int.MaxValue, ErrorMessage = "Enter a year after 1888, the year the first movie came out.")]
    public int Year { get; set; }
    
    public string? Director { get; set; }
    
    public string? Rating { get; set; }
    
    [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
    // a boolean for Edited value
    [Required]
    public int Edited { get; set; }
   
    // allows for LentTo value to be null
    public string? LentTo { get; set; }
   
    // allows for Notes value to be null
    public string? Notes { get; set; }
    [Required]
    public int CopiedToPlex { get; set; }
    
}