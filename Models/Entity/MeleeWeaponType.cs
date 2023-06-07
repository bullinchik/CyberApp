using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class MeleeWeaponType
{
    [Key] public int MeleeWeaponTypeId { get; set; }
    public string MeleeWeaponTypeName { get; set; }
}