using CyberApp.Data.Model.Entity;

namespace CyberApp.Data.Model.Models;

public class QuestionsModel
{
    public List<ClassQuestion> ClassQuestions { get; set; }
    public List<GeneralQuestion> GeneralQuestions { get; set; }
}