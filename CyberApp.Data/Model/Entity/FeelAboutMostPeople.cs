using System.ComponentModel.DataAnnotations;

namespace  CyberApp.Data.Models.Entity;

public class FeelAboutMostPeople
{
    [Key] public int Id { get; set; }
    public string Description { get; set; }
}