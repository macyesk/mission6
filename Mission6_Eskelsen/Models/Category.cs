using System.ComponentModel.DataAnnotations;

namespace Mission6_Eskelsen.Models;

public class Category
{
    // entries required for category entry
    [Key]
    [Required]
    public int CategoryId { get; set; }
    
    [Required]
    public string CategoryName { get; set; }
    
}