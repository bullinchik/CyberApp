namespace CyberApp.Data.Model.Models;

public class CharacterClass
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; } //Я не знаю как нормально обращаться к файлу иконки, по хорошму это должно быть файлом или статическим классом, но уже как есть
    public string Description { get; set; }
}