using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class MostValuePerson
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
}