using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class CharacterClass
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Image { get; set; }
    public string? Description { get; set; }
    
    public List<CharacterPresetStats> Stats { get; set; }
    public List<CharacterSkills> Skills { get; set; }
}