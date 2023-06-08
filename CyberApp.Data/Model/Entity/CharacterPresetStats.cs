using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class CharacterPresetStats
{
    [Key] 
    public int Id { get; set; }

    public int CharacterClassId { get; set; }

    public int StatId { get; set; }
    public Stat Stat { get; set; }
    public int Value { get; set; }
}