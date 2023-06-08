using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class Cost
{
    [Key] public int Id { get; set; }
    public int Price { get; set; }
    public string? Name { get; set; }
}