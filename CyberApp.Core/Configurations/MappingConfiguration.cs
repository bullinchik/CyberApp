using CyberApp.Data.Model.Entity;
using CyberApp.Mapper;

namespace CyberApp.Configurations;

public static class MappingConfiguration
{
    public static void AddMapping(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(QuestionProfile));
    }
}