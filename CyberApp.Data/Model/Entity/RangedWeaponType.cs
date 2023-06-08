using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class RangedWeaponType
{
    [Key] public int RangedWeaponTypeId { get; set; }
    public string RangedWeaponTypeName { get; set; }
}
