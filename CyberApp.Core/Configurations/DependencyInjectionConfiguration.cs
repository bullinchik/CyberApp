using CyberApp.Services.Contracts;
using CyberApp.Services.Implementations;

namespace CyberApp.Configurations;

public static class DependencyInjectionConfiguration
{
    public static void AddDependencyInjection(this IServiceCollection services)
    {
        AddServices(services);
    }

    private static void AddServices(IServiceCollection services)
    {
        services.AddSingleton<IQuestionsService, QuestionsService>();
    }
}