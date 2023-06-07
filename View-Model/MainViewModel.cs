using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Xml;
using System.Xml.Serialization;
using CyberApp.Models;
using CyberApp.View;
using Application = Microsoft.Maui.Controls.Application;

namespace CyberApp.View_Model;

public class MainViewModel : INotifyPropertyChanged
{
    private string firtsName = "";
    private string nickName = "";
    public ICommand ImportCharacter { get; set; }
    public ICommand CreateCharacter { get; set; }
    public ObservableCollection<Character> Character { get; } 
    public event PropertyChangedEventHandler PropertyChanged;

    public MainViewModel()
    {
        ImportCharacter = new Command(() =>
        {
            var customFileType = new FilePickerFileType(
                new Dictionary<DevicePlatform, IEnumerable<string>>
                {
                    { DevicePlatform.iOS, new[] { "public.xml" } }, // UTType values
                    { DevicePlatform.Android, new[] { "application/xml" } }, // MIME type
                    { DevicePlatform.WinUI, new[] { ".xml" } }, // file extension
                    { DevicePlatform.macOS, new[] { "xml" } }, // UTType values
                });
        
            PickOptions options = new()
            {
                PickerTitle = "Please select a comic file",
                FileTypes = customFileType,
            };
        
            //Character files =  PickCharacters(options);
        });
        CreateCharacter = new Command(() =>
        {
            Application.Current.MainPage.Navigation.PushAsync(new CreateCharacter());
        });
    }

    private Character PickCharacters(PickOptions options)
    {
        try
        {
            var result = FilePicker.Default.PickAsync(options).Result;
            XmlSerializer xmlDeserializer = new XmlSerializer(typeof(Character));
            if (result != null && result.FileName.EndsWith("xml", StringComparison.OrdinalIgnoreCase))
            {
                using (FileStream fs = new FileStream(result.FullPath, FileMode.Open))
                {
                    Character? character = xmlDeserializer.Deserialize(fs) as Character;
                    return character;
                }
            }
        }
        catch (XmlException ex)
        {
            Application.Current.MainPage.DisplayAlert("Внимание!", ex.Message, "Ок");
        }
        catch (FileNotFoundException ex)
        {
            Application.Current.MainPage.DisplayAlert("Внимание!", ex.Message, "Ок");
        }

        return null;
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}