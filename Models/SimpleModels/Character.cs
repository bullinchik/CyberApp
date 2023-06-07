using CyberApp.Models;

public class Character
{
    public string FirstName { get; set; } = "";

    public string SecondName { get; set; } = "";
    public string NickName { get; set; } = "";

    public string CharacterIcon { get; set; }

    public CharacterClass CharacterClass { get; set; }
    public int Age { get; set; }

    public string PersonalInformation { get; set; } //сюда парсить все вопросы и ответы через \n в одну большую строку 

    public IEnumerable<Item> Items { get; set; }

    public IEnumerable<Skill> Skills { get; set; }

    public IEnumerable<STAT> Stats { get; set; }
}