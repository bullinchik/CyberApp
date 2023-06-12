
using CyberApp.View_Model;

namespace CyberApp.View;

public partial class SelectCharacterCreaterView : ContentPage
{
    public SelectCharacterCreaterView()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ClassSelectionView(_serviceProvider.GetRequiredService<ClassSelectionViewModel>()));
    }
}