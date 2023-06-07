using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class AffectionYouAreNeverWithout
{
    [Key] public int AffectionYouAreNeverWithoutId { get; set; }
    public string AffectionYouAreNeverWithoutDescription { get; set; }
}