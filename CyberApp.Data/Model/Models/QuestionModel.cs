namespace CyberApp.Data.Model.Models;

public class QuestionModel
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;
    public ICollection<QuestionAnswerModel> Answers { get; set; }
}