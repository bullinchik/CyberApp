using CyberApp.Data.Model.Models;

namespace CyberApp.Services.Contracts;

public interface IQuestionsService
{
    QuestionsModel Get(int classId);
}