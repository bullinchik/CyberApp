using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class AffectionYouAreNeverWithout
{
    [Key] public int AffectionYouAreNeverWithoutId { get; set; }
    public string AffectionYouAreNeverWithoutDescription { get; set; }
}