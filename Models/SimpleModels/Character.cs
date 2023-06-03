using CyberApp.Models.DatabaseModels;

namespace CyberApp.Models;

public class Character
{
    public string FirstName { get; set; } = "";

    public string SecondName { get; set; } = "";
    public string NickName { get; set; } = "";

    public string CharacterIcon { get; set; }

    public CharacterClass CharacterClass { get; set; }
    public int Age { get; set; }
}