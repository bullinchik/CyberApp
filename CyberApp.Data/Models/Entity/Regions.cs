using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class Regions
{
    [Key]
    public int RegionId { get; set; }
    public string RegionName { get; set; }
}