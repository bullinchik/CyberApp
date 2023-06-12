using CyberApp.View;
using CyberApp.View_Model;

namespace CyberApp;

public partial class App : Application
{
    public App(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        MainPage = new AppShell();
        MainPage = new NavigationPage(new MainPage());
        BindingContext = new MainViewModel(serviceProvider);
    }
}