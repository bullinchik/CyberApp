using CyberApp.Models;
using Microsoft.Maui.Controls.Shapes;

namespace CyberApp;
public partial class MainPage : ContentPage
{
    public List<Character> Characters { get; set; }

    public MainPage()
    {
        InitializeComponent();
        Characters = new List<Character>
        {
            new Character {FirstName= "Tom Hardy", NickName = "Redeye", Age=38, CharacterIcon = "exec.png" } ,
            new Character {FirstName= "Harry Dubua", NickName = "Bullseye", Age=38, CharacterIcon = "nomad.png" }
        };
        ViewCharacters.ItemsSource = Characters;
    }
}