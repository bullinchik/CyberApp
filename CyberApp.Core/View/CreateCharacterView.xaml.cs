
using CyberApp.View_Model;

namespace CyberApp.View;

public partial class SelectCharacterCreaterView : ContentPage
{
    private readonly IServiceProvider _serviceProvider;
    public SelectCharacterCreaterView(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _serviceProvider = serviceProvider;
    }
}