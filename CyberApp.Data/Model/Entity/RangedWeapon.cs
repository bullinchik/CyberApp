using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class RangedWeapon
{
    [Key] public int RangedWeaponId { get; set; }
    public int RangedWeaponTypeId { get; set; }
    public virtual RangedWeaponType RangedWeaponType { get; set; }
    public int SkillId { get; set; }
    public virtual Skill Skill { get; set; }
    public int SingleShotDamage { get; set; }
    public int MagazineSize { get; set; }
    public int RateOfFire { get; set; }
    public int HandsRequired { get; set; }
    public bool IsConcealable { get; set; }
    public int CostId { get; set; }
    public virtual Cost Cost { get; set; }
}