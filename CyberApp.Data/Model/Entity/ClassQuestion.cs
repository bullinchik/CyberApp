using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class ClassQuestion
{
    public ClassQuestion()
    {
        Answers = new List<ClassQuestionAnswer>();
    }

    [Key] 
    public int Id { get; set; }
    public int ClassId { get; set; }
    public string Text { get; set; } = null!;
    public ICollection<ClassQuestionAnswer> Answers { get; set; }
}