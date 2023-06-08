using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class StoryQuestion
{
    [Key] 
    public int Id { get; set; }
    public int ClassId { get; set; }
    public int StoryQuestionTextId { get; set; }
    public List<StoryClassQuestionAnswers> Answers { get; set; }
}