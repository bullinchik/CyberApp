using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class CharacterClass
{
    [Key]
    public int CharacterClassId { get; set; }
    public string CharacterClassName { get; set; }
    public string CharacterClassImageName { get; set; }
    public string Description { get; set; }
}