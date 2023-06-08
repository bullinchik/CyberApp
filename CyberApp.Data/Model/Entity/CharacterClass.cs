using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class CharacterClass
{
    public CharacterClass()
    {
        Stats = new List<CharacterPresetStats>();
        Skills = new List<CharacterSkills>();
    }

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Image { get; set; }
    public string? Description { get; set; }
    
    public ICollection<CharacterPresetStats> Stats { get; set; }
    public ICollection<CharacterSkills> Skills { get; set; }
}