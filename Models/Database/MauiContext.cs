using CyberApp.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace CyberApp.Models.Database;

public class MauiContext : DbContext
{
    public DbSet<AffectionYouAreNeverWithout> AffectionYouAreNeverWithoutEnumerable { get; set; }
    public DbSet<CharacterClass> CharacterClasses { get; set; }
    public DbSet<CharacterSkills> CharacterSkillsEnumerable { get; set; }
    public DbSet<CharacterSTAT> CharacterStats { get; set; }
    public DbSet<Childhood> Childhoods { get; set; }
    public DbSet<ClothingStyle> ClothingStyles { get; set; }
    public DbSet<Cost> Costs { get; set; }
    public DbSet<FamilyCrysis> FamilyCrysisEnumerable { get; set; }
    public DbSet<FeelAboutMostPeople> FeelAboutMostPeopleEnumerable { get; set; }
    public DbSet<Goals> GoalsEnumerable { get; set; }
    public DbSet<HairStyle> HairStyles { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<MeleeWeapon> MeleeWeapons { get; set; }
    public DbSet<MeleeWeaponType> MeleeWeaponTypes { get; set; }
    public DbSet<MostValue> MostValues { get; set; }
    public DbSet<MostValuePerson> MostValuePersons { get; set; }
    public DbSet<RangedWeapon> RangedWeapons { get; set; }
    public DbSet<RangedWeaponType> RangedWeaponTypes { get; set; }
    public DbSet<Regions> RegionsEnumerable { get; set; }
    public DbSet<Skill> SkillEnumerable { get; set; }
    public DbSet<STAT> StatEnumerable { get; set; }
    public DbSet<StoryClassQuestionText> StoryClassQuestionTextEnumerable { get; set; }
    public DbSet<StoryQuestion> StoryQuestions { get; set; }
    public DbSet<WhatAreYouLike> WhatAreYouLikeEnumerable { get; set; }

    public MauiContext() => Database.EnsureCreated();
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=cyber.db");
    }
}