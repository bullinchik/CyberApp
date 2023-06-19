using System.Windows.Input;
using CyberApp.Data.Model.Entity;
using CyberApp.Services.Implementations;
using CyberApp.View_Model;

namespace CyberApp.View;

public partial class ClassSelectionView : TabbedPage
{
    private Page _previousPage;
    private CharacterClass _currentClass;
    public ClassSelectionView(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        ClassSelectionViewModel classSelectionViewModel = new ClassSelectionViewModel(serviceProvider.GetService<ClassService>()); 
        BindingContext = classSelectionViewModel;
        
        ItemsSource = classSelectionViewModel.ClassCollection;

        _currentClass = SelectedItem as CharacterClass;
        
        SetCommandsForAllPages();
        
        this.CurrentPageChanged += (object IntentSender, EventArgs e) =>
        {
            OnImagePress( _previousPage, false);
            _currentClass = SelectedItem as CharacterClass;
        };
    }

    private void SetCommandsForAllPages()
    {
        ICommand cancelClass = new Command(CancelCurrentClass);
        ICommand confirmClass = new Command(ConfirmClass);
        
        foreach (var page in Children)
        {
            Image image = page.FindByName("ImageView") as Image;
            Button cancelButton = page.FindByName("CancelButton") as Button;
            Button crossButton = page.FindByName("CrossButton") as Button;
            Button confirmButton = page.FindByName("ConfirmButton") as Button;

            crossButton.Command = cancelClass;
            cancelButton.Command = cancelClass;
            
            confirmButton.Command = confirmClass;
            
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += delegate(object sender, TappedEventArgs args) { OnImagePress(CurrentPage, true); };
            image.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }

    private void OnImagePress(Page page, bool setIsImageVisible)
    {
        Image classImage = page.FindByName("ImageView") as Image;
        Grid grid = page.FindByName("DescriptionView") as Grid;
        classImage.IsVisible = !setIsImageVisible;
        grid.IsVisible = setIsImageVisible;
        _previousPage = CurrentPage;
    }

    private void CancelCurrentClass()
    {
        OnImagePress(CurrentPage, false);
    }

    private void ConfirmClass()
    {
        Navigation.PushAsync(new CreateCharacterView(_currentClass));
    }
}