using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class Skill
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public int BaseStatId { get; set; }

    public Stat BaseStat { get; set; }
}