using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class StoryQuestion
{
    [Key] 
    public int StoryQuesionId { get; set; }
    public int ClassId { get; set; }
    public virtual CharacterClass CharacterClass { get; set; }
    public string StoryQuestionAnswer { get; set; }
}