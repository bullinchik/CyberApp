using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class Goals
{
    [Key] public int GoalsId { get; set; }
    public string GoalsDescription { get; set; }
}
