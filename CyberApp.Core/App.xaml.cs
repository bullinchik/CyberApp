using CyberApp.View;
using CyberApp.View_Model;

namespace CyberApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
        MainPage = new NavigationPage(new MainPage());
        BindingContext = new MainViewModel();
    }
}