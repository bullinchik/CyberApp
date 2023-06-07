using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class Skill
{
    [Key]
    public int SkillId { get; set; }

    public string SkillName { get; set; }

    public int STATId { get; set; }

    public virtual STAT Stat { get; set; }
    
}