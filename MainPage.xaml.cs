using CyberApp.Models;
namespace CyberApp;
public partial class MainPage : ContentPage
{
    public List<User> Users { get; set; }

    public MainPage()
    {
        InitializeComponent();
        Label header = new Label { Text = "Список пользователей", FontSize = 18 };
        Users = new List<User>
        {
            new User {Name="Tom", Age=38 },
            new User {Name = "Bob", Age= 42},
            new User {Name="Sam", Age = 28},
            new User {Name = "Alice", Age = 33}
        };
        
        ViewCharacters.ItemsSource = Users;
        ViewCharacters.ItemTemplate = new DataTemplate(() =>
        {
            // привязка к свойству Name
            Label nameLabel = new Label { FontSize = 16 };
            nameLabel.SetBinding(Label.TextProperty, "Name");
 
            // привязка к свойству Age
            Label ageLabel = new Label { FontSize = 14 };
            ageLabel.SetBinding(Label.TextProperty, "Age");
 
            return new ViewCell
            {
                View = new StackLayout
                {
                    Padding = new Thickness(0, 5),
                    Orientation = StackOrientation.Vertical,
                    Children = { nameLabel, ageLabel }
                }
            };
        });
    }
}