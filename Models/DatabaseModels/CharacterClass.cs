using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class CharacterClass
{
    [Key]
    public int CharacterClassId { get; set; }
    public string CharacterClassName { get; set; }
    public string CharacterClassImageName { get; set; }
    public string Description { get; set; }
}