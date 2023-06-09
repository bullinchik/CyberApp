using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class MeleeWeapon
{
    [Key] 
    public int Id;
    public int MeleeWeaponTypeId { get; set; }
    public virtual MeleeWeaponType MeleeWeaponType { get; set; }
    public int Damage { get; set; }
    public int RateOfFire { get; set; }
    public bool IsConcealable { get; set; }
    public int CostId { get; set; }
    public virtual Cost Cost { get; set; }
}