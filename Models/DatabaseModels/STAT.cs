using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class STAT
{
    [Key] 
    public int STATId { get; set; }

    public string STAT_Name { get; set; }
}