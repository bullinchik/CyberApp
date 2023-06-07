using System.ComponentModel.DataAnnotations;

namespace  CyberApp.Data.Models.Entity;

public class FeelAboutMostPeople
{
    [Key] public int FeelAboutMostPeopleId { get; set; }
    public string FeelAboutMostPeopleDescription { get; set; }
}