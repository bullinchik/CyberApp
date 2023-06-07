using System.ComponentModel.DataAnnotations;

namespace  CyberApp.Models.DatabaseModels;

public class FeelAboutMostPeople
{
    [Key] public int FeelAboutMostPeopleId { get; set; }
    public string FeelAboutMostPeopleDescription { get; set; }
}