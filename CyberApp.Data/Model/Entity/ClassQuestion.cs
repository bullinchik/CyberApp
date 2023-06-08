using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class ClassQuestion
{
    public ClassQuestion()
    {
        Answers = new List<ClassQuestionAnswers>();
    }

    [Key] 
    public int Id { get; set; }
    public int ClassId { get; set; }
    public int StoryQuestionTextId { get; set; }
    public ICollection<ClassQuestionAnswers> Answers { get; set; }
}