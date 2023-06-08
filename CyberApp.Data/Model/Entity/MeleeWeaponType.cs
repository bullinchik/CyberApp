using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class MeleeWeaponType
{
    [Key] public int MeleeWeaponTypeId { get; set; }
    public string MeleeWeaponTypeName { get; set; }
}