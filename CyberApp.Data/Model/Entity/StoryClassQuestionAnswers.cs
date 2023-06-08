using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class StoryClassQuestionAnswers
{
    [Key] public int Id { get; set; }
    
    public string Answer { get; set; }
}