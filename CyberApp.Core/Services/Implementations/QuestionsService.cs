using CyberApp.Data;
using CyberApp.Data.Model.Models;
using CyberApp.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CyberApp.Services.Implementations;

public class QuestionsService : IQuestionsService
{
    private readonly DatabaseContext _context;

    public QuestionsService(DatabaseContext context)
    {
        _context = context;
    }
    
    public QuestionsModel Get(int classId)
    {
        var questionsModel = new QuestionsModel()
        {
            ClassQuestions = _context.ClassQuestions.Where(x => x.ClassId == classId).Include(x => x.Answers).ToList(),
            GeneralQuestions = _context.GeneralQuestions.Include(x => x.Answers).ToList(),
        };
        return questionsModel;
    }
}