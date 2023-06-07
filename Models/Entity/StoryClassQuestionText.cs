using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class StoryClassQuestionText
{
    [Key] public int StoryClassQuestionTextId { get; set; }
    
    public string StoryClassQuestionValue { get; set; }
}