using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class Childhood
{
    [Key]
    public int ChildhoodId { get; set; }

    public string ChildhoodDescription { get; set; }
}