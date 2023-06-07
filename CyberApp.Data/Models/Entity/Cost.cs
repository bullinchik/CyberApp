using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class Cost
{
    [Key] public int CostId { get; set; }
    public int Price { get; set; }
    public string PriceName { get; set; }
}