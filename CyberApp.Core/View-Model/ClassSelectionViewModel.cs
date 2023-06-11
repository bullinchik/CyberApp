using System.Collections.ObjectModel;
using System.Windows.Input;
using CyberApp.Data.Model.Models;

namespace CyberApp.View_Model;

public class ClassSelectionViewModel
{
    public ICommand SelectClass { get; set; }
    
    public ObservableCollection<CharacterClass> ClassCollection;

    public ClassSelectionViewModel()
    {
        // ClassCollection = new ClassService();

        SelectClass = new Command(() =>
        {
            //to do
        });
    }
}