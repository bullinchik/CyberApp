using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Models.Entity;

public class Language
{
    [Key] public int LanguageId { get; set; }
    public string LanguageName { get; set; }
}