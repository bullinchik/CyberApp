using CyberApp.Data.Model.Entity;
using Microsoft.EntityFrameworkCore;
using CharacterClass = CyberApp.Data.Model.Models.CharacterClass;
using Skill = CyberApp.Data.Model.Models.Skill;
using Stat = CyberApp.Data.Model.Models.Stat;

namespace CyberApp.Data;

public class DatabaseContext : DbContext
{
    public DbSet<CharacterClass> CharacterClasses { get; set; } = null!;
    public DbSet<CharacterSkills> CharacterSkills { get; set; } = null!;
    public DbSet<CharacterPresetStats> CharacterStats { get; set; } = null!;
    public DbSet<Cost> Costs { get; set; } = null!;
    public DbSet<MeleeWeapon> MeleeWeapons { get; set; } = null!;
    public DbSet<MeleeWeaponType> MeleeWeaponTypes { get; set; } = null!;
    public DbSet<RangedWeapon> RangedWeapons { get; set; } = null!;
    public DbSet<RangedWeaponType> RangedWeaponTypes { get; set; } = null!;
    public DbSet<Skill> Skills { get; set; } = null!;
    public DbSet<Stat> Stats { get; set; } = null!;
    public DbSet<ClassQuestionAnswers> ClassQuestionAnswers { get; set; } = null!;
    public DbSet<ClassQuestion> ClassQuestions { get; set; } = null!;
    public DbSet<GeneralQuestion> GeneralQuestions { get; set; } = null!;
    public DbSet<GeneralQuestionAnswer> GeneralQuestionAnswers { get; set; } = null!;

    public DatabaseContext()
    {
        File = Path.Combine("../", "UsedByMigratorOnly1.db3");
        Initialize();
    }

    public DatabaseContext(string filenameWithPath)
    {
        File = filenameWithPath;
        Initialize();
    }

    private void Initialize()
    {
        if (!Initialized)
        {
            Initialized = true;

            SQLitePCL.Batteries_V2.Init();

            Database.Migrate();
        }
    }

    public static string File { get; protected set; }
    public static bool Initialized { get; protected set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlite($"Filename={File}");
    }

    public void Reload()
    {
        Database.CloseConnection();
        Database.OpenConnection();
    }
}