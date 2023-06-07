using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class ClothingStyle
{
    [Key] 
    public int ClothingStyleId { get; set; }
    public string ClothingStyleName { get; set; }
    public string ClothingStyleDescription { get; set; }
}