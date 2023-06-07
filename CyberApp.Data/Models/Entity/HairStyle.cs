using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class HairStyle
{
    [Key] public int HairStyleId { get; set; }
    public string HairSyleDescription { get; set; }
}
