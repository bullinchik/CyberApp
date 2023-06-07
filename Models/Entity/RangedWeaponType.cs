using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class RangedWeaponType
{
    [Key] public int RangedWeaponTypeId { get; set; }
    public string RangedWeaponTypeName { get; set; }
}
