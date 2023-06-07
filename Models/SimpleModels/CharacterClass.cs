namespace CyberApp.Models;

public class CharacterClass
{
    public int CharacterClassId { get; set; }
    public string CharacterClassName { get; set; }
    public string CharacterClassImageName { get; set; } //Я не знаю как нормально обращаться к файлу иконки, по хорошму это должно быть файлом или статическим классом, но уже как есть
    public string Description { get; set; }
}