using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class Goals
{
    [Key] public int GoalsId { get; set; }
    public string GoalsDescription { get; set; }
}
