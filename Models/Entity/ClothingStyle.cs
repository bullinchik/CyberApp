using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class ClothingStyle
{
    [Key] 
    public int ClothingStyleId { get; set; }
    public string ClothingStyleName { get; set; }
    public string ClothingStyleDescription { get; set; }
}