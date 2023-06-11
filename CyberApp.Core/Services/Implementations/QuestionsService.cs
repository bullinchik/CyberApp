using AutoMapper;
using CyberApp.Data;
using CyberApp.Data.Model.Entity;
using CyberApp.Data.Model.Models;
using CyberApp.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CyberApp.Services.Implementations;

public class QuestionsService : IQuestionsService
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    public QuestionsService(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public QuestionsCollectionModel Get(int classId)
    {
        var classQuestions = _context.ClassQuestions
            .Where(x => x.ClassId == classId)
            .Include(x => x.Answers)
            .ToList();
        var generalQuestions = _context.GeneralQuestions
            .Include(x => x.Answers)
            .ToList();
        
        var questionsModel = new QuestionsCollectionModel()
        {
            ClassQuestions = _mapper.Map<List<QuestionModel>>(classQuestions),
            GeneralQuestions = _mapper.Map<List<QuestionModel>>(generalQuestions)
        };
        return questionsModel;
    }
}