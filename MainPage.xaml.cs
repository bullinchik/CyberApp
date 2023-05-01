using System.Drawing;
using Image = System.Drawing.Image;
using CyberApp.Models;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace CyberApp;
public partial class MainPage : ContentPage
{
    public List<Character> Characters { get; set; }

    public MainPage()
    {
        InitializeComponent();
        Characters = new List<Character>
        {
            new Character {FirstName= "Tom Hardy", NickName = "Redeye", Age=38, ClassIcon = "fixer.png"},
            new Character {FirstName= "Harry Dubua", NickName = "Bullseye", Age=38, ClassIcon = "nomad.png"}
        };
        
        ViewCharacters.ItemsSource = Characters;
    }
}