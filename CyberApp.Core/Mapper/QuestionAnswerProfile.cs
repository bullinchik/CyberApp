using AutoMapper;
using CyberApp.Data.Model.Entity;
using CyberApp.Data.Model.Models;

namespace CyberApp.Mapper;

public class QuestionAnswerProfile : Profile
{
    public QuestionAnswerProfile()
    {
        CreateMap<ClassQuestionAnswer, QuestionAnswerModel>();
        CreateMap<GeneralQuestionAnswer, QuestionAnswerModel>();
    }
}