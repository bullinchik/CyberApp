using CyberApp.Data.Model.Models;

namespace CyberApp.Services.Contracts;

public interface IQuestionsService
{
    QuestionsCollectionModel Get(int classId);
}