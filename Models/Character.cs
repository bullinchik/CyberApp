using CyberApp.Models.DatabaseModels;
using Image = System.Drawing.Image;

namespace CyberApp.Models;

public class Character
{
    public string FirstName { get; set; } = "";
    public string NickName { get; set; } = "";

    public string ClassIcon { get; set; }

    public CharacterClass CharacterClass { get; set; }
    public int Age { get; set; }
}