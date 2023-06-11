
namespace CyberApp.View;

public partial class CreateCharacter : ContentPage
{
    public CreateCharacter()
    {
        InitializeComponent();
    }


    private void Button_OnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ClassSelection());
    }
}