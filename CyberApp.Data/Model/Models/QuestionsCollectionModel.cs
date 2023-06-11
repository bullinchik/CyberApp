using CyberApp.Data.Model.Entity;

namespace CyberApp.Data.Model.Models;

public class QuestionsCollectionModel
{
    public List<QuestionModel> ClassQuestions { get; set; }
    public List<QuestionModel> GeneralQuestions { get; set; }
}