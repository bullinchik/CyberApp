using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class STAT
{
    [Key] 
    public int STATId { get; set; }

    public string STAT_Name { get; set; }
}