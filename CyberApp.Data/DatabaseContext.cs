using CyberApp.Data.Models.Entity;
using CyberApp.Data.Models.SimpleModels;
using Microsoft.EntityFrameworkCore;
using CharacterClass = CyberApp.Data.Models.SimpleModels.CharacterClass;
using Skill = CyberApp.Data.Models.SimpleModels.Skill;

namespace CyberApp.Data;

public class DatabaseContext : DbContext
{
    public DbSet<AffectionYouAreNeverWithout> AffectionYouAreNeverWithoutEnumerable { get; set; } = null!;
    public DbSet<CharacterClass> CharacterClasses { get; set; } = null!;
    public DbSet<CharacterSkills> CharacterSkillsEnumerable { get; set; } = null!;
    public DbSet<CharacterSTAT> CharacterStats { get; set; } = null!;
    public DbSet<Childhood> Childhoods { get; set; } = null!;
    public DbSet<ClothingStyle> ClothingStyles { get; set; } = null!;
    public DbSet<Cost> Costs { get; set; } = null!;
    public DbSet<FamilyCrysis> FamilyCrisisEnumerable { get; set; } = null!;
    public DbSet<FeelAboutMostPeople> FeelAboutMostPeopleEnumerable { get; set; } = null!;
    public DbSet<Goals> GoalsEnumerable { get; set; } = null!;
    public DbSet<HairStyle> HairStyles { get; set; } = null!;
    public DbSet<Language> Languages { get; set; } = null!;
    public DbSet<MeleeWeapon> MeleeWeapons { get; set; } = null!;
    public DbSet<MeleeWeaponType> MeleeWeaponTypes { get; set; } = null!;
    public DbSet<MostValue> MostValues { get; set; } = null!;
    public DbSet<MostValuePerson> MostValuePersons { get; set; } = null!;
    public DbSet<RangedWeapon> RangedWeapons { get; set; } = null!;
    public DbSet<RangedWeaponType> RangedWeaponTypes { get; set; } = null!;
    public DbSet<Regions> RegionsEnumerable { get; set; } = null!;
    public DbSet<Skill> SkillEnumerable { get; set; } = null!;
    public DbSet<Stat> StatEnumerable { get; set; } = null!;
    public DbSet<StoryClassQuestionText> StoryClassQuestionTextEnumerable { get; set; } = null!;
    public DbSet<StoryQuestion> StoryQuestions { get; set; } = null!;
    public DbSet<WhatAreYouLike> WhatAreYouLikeEnumerable { get; set; } = null!;

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