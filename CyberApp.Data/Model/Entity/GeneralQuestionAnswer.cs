using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class GeneralQuestionAnswer
{
    [Key]
    public int Id { get; set; }

    public string Text { get; set; } = null!;
}