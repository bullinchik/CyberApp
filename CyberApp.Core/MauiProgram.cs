using CyberApp.Configurations;
using CyberApp.Data;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace CyberApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();

        builder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            fonts.AddFont("MaterialIcons.ttf", "MaterialIcons");
        });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddDatabaseContext();
        builder.Services.AddDependencyInjection();
        builder.Services.AddMapping();

        return builder.Build();
    }
}