namespace CyberApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    protected override void OnNavigated(ShellNavigatedEventArgs args)
    {
        base.OnNavigated(args);
        title.Text = Shell.Current.CurrentItem.Title;
    }


    private void OnDeleteCharactersClick(object sender, EventArgs e)
    {
        Console.WriteLine("no delete ... ");
    }
}