using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class MostValue
{
    [Key] public int MostValueId { get; set; }
    public string MostValueDescription { get; set; }
}