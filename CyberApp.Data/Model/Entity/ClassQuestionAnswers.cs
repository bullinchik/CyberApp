using System.ComponentModel.DataAnnotations;

namespace CyberApp.Data.Model.Entity;

public class ClassQuestionAnswers
{
    [Key] public int Id { get; set; }

    public string Answer { get; set; } = null!;
}