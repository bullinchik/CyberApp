using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class CharacterSkills
{
    [Key]
    public int Id { get; set; }
    public int Value { get; set; }
    public int CharacterClassId { get; set; }
}