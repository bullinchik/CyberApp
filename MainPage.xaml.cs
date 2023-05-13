using System.Numerics;
using CyberApp.Models;

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
            new Character {FirstName= "Harry Dubua", NickName = "Bullseye", Age=38, CharacterIcon = "nomad.png" },
            new Character {FirstName = "Lorem Ipsum", NickName = "Lorem Ipsum", Age = 18, CharacterIcon = "solo.png"},
            new Character {FirstName = "Lorem Ipsum", NickName = "BlackBear", Age = 25, CharacterIcon = "lawman.png"}
        };
        ViewCharacters.ItemsSource = Characters;
    }

    private void OnImportCharacterTapped(object sender, TappedEventArgs e)
    {
        var customFileType = new FilePickerFileType(
            new Dictionary<DevicePlatform, IEnumerable<string>>
            {
                { DevicePlatform.iOS, new[] { "public.xml" } }, // UTType values
                { DevicePlatform.Android, new[] { "application/xml" } }, // MIME type
                { DevicePlatform.WinUI, new[] { ".xml", ".xml" } }, // file extension
                { DevicePlatform.macOS, new[] { "xml", "xml" } }, // UTType values
            });

        PickOptions options = new()
        {
            PickerTitle = "Please select a comic file",
            FileTypes = customFileType,
        };

        var files = PickCharacters(options);
    }

    private async Task<FileResult> PickCharacters(PickOptions options)
    {
        try
        {
            var result = await FilePicker.Default.PickAsync(options);
            if (result != null)
            {
                if (result.FileName.EndsWith("xml", StringComparison.OrdinalIgnoreCase))
                {
                    using var stream = await result.OpenReadAsync();
                    var image = ImageSource.FromStream(() => stream);
                }
            }

            return result;
        }
        catch (Exception ex)
        {
            // The user canceled or something went wrong
        }

        return null;
    }
}