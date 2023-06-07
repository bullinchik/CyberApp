using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class MostValuePerson
{
    [Key] public int MostValuePersonId { get; set; }
    public string MostValuePersonName { get; set; }
}