using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class CharacterSTAT
{
    [Key] 
    public int CharacterSTATId { get; set; }

    public int CharacterClassId { get; set; }

    public virtual CharacterClass CharacterClass { get; set; }

    public int STATId { get; set; }

    public virtual STAT Stat { get; set; }

    public int STATValue { get; set; }
}