using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class StoryClassQuestionText
{
    [Key] public int StoryClassQuestionTextId { get; set; }
    
    public string StoryClassQuestionValue { get; set; }
}