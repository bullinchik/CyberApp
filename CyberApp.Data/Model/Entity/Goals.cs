using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class Goals
{
    [Key] public int Id { get; set; }
    public string Description { get; set; }
}
