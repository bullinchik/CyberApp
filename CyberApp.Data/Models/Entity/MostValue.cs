using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class MostValue
{
    [Key] public int MostValueId { get; set; }
    public string MostValueDescription { get; set; }
}