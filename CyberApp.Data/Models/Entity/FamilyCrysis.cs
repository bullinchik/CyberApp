using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class FamilyCrysis
{
    [Key]
    public int FamilyCrysisId { get; set; }

    public string FamilyCrysisDescription { get; set; }
}