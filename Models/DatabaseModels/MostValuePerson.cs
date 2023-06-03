using System.ComponentModel.DataAnnotations;

namespace CyberApp.Models.DatabaseModels;

public class MostValuePerson
{
    [Key] public int MostValuePersonId { get; set; }
    public string MostValuePersonName { get; set; }
}