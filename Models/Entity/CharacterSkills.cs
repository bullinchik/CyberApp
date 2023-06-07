using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class CharacterSkills
{
    [Key] 
    public int CharacterSkillsId { get; set; }

    public int CharacterClassId { get; set; }

    public int CharacterSkillValue { get; set; }

    public virtual CharacterClass CharacterClass { get; set; }

    public int CharacterSTATId { get; set; }

    public virtual STAT Stat { get; set; }
}