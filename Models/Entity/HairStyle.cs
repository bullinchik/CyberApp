using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class HairStyle
{
    [Key] public int HairStyleId { get; set; }
    public string HairSyleDescription { get; set; }
}
