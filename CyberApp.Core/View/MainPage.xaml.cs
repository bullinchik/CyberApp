using CyberApp.Data.Model.Models;
using CyberApp.Data.Models;
using CyberApp.View_Model;

namespace CyberApp.View;
public partial class MainPage : ContentPage
{
    public List<Character> Characters { get; set; }

    public MainPage()
    {
        InitializeComponent();
        Characters = new List<Character>
        {
            new Character {FirstName= "Tom Hardy", NickName = "Redeye", Age=38, CharacterIcon = "exec.png" } ,
            new Character {FirstName= "Harry Dubua", NickName = "Bullseye", Age=38, CharacterIcon = "nomad.png" },
            new Character {FirstName = "Lorem Ipsum", NickName = "Lorem Ipsum", Age = 18, CharacterIcon = "solo.png"},
            new Character {FirstName = "Lorem Ipsum", NickName = "BlackBear", Age = 25, CharacterIcon = "lawman.png"}
        };
        ViewCharacters.ItemsSource = Characters;
    }
    
    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        titleViewGrid.WidthRequest = width;
    }
}