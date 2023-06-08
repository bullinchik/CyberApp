using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class GeneralQuestion
{
    public GeneralQuestion()
    {
        Answers = new List<GeneralQuestionAnswer>();
    }
    
    [Key]
    public int Id { get; set; }
    
    public string Text { get; set; } = null!;
    public ICollection<GeneralQuestionAnswer> Answers { get; set; }
}