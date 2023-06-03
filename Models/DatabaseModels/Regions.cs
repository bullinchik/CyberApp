using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class Regions
{
    [Key]
    public int RegionId { get; set; }
    public string RegionName { get; set; }
}