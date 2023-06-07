using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class Childhood
{
    [Key]
    public int ChildhoodId { get; set; }

    public string ChildhoodDescription { get; set; }
}