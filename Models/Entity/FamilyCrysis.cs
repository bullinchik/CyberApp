using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class FamilyCrysis
{
    [Key]
    public int FamilyCrysisId { get; set; }

    public string FamilyCrysisDescription { get; set; }
}