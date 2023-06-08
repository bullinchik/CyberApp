using CyberApp.Data;

namespace CyberApp.Configurations;

public static class DatabaseContextConfiguration
{
    public static void AddDatabaseContext(this IServiceCollection services)
    {
        services.AddTransient<DatabaseContext>((services) =>
            new DatabaseContext(Path.Combine(FileSystem.AppDataDirectory, "SQLite001.db3")));
    }
}