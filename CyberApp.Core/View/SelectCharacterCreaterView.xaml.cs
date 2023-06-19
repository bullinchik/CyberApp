
using CyberApp.View_Model;

namespace CyberApp.View;

public partial class SelectCharacterCreaterView : ContentPage
{
    private IServiceProvider _serviceProvider;
    public SelectCharacterCreaterView(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ClassSelectionView(_serviceProvider));
    }
}