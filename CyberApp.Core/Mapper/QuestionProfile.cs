using AutoMapper;
using CyberApp.Data.Model.Entity;
using CyberApp.Data.Model.Models;

namespace CyberApp.Mapper;

public class QuestionProfile : Profile
{
    public QuestionProfile()
    {
        CreateMap<ClassQuestion, QuestionModel>();
        CreateMap<GeneralQuestion, QuestionModel>();
    }
}