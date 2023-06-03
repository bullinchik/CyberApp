using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class Region
{
    [Key]
    public int RegionId { get; set; }
    public string RegionName { get; set; }
}