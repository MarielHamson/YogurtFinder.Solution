using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YogurtFinder.Models
{
  public class Yogurt
  {

    public int YogurtId { get; set; }
    [Required]
    public string Brand { get; set; }
    [Required]
    public string Flavor { get; set; }
    [Required]
    public bool Blended { get; set; }
    [Required]
    public string Type { get; set; }
    [Range(0, 500, ErrorMessage = "Must be between 1 and 500.")]
    public int Protein { get; set; }
    [Range(0, 500, ErrorMessage = "Must be between 1 and 500.")]
    public int Sugar { get; set; }
    [Range(0, 500, ErrorMessage = "Must be between 1 and 500.")]
    public int Fat { get; set; }
    [Range(0, 500, ErrorMessage = "Must be between 1 and 500.")]
    public int Carbs { get; set; }
    [Range(0, 1000, ErrorMessage = "Must be between 1 and 1000.")]
    public int Calories { get; set; } 
    }
  }