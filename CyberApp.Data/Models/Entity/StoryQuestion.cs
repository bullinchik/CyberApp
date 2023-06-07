using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class StoryQuestion
{
    [Key] 
    public int StoryQuesionTextId { get; set; }
    public int ClassId { get; set; }
    public virtual CharacterClass CharacterClass { get; set; }
    public int StoryQuestionTextId { get; set; }
    public virtual StoryClassQuestionText StoryClassQuestionText { get; set; }
    public string StoryQuestionAnswer { get; set; }
}