using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class StoryClassQuestion
{
    [Key] public int StoryClassQuestionId { get; set; }
    public string StokyClassQuestionText { get; set; }
}