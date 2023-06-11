using System.Collections.ObjectModel;
using System.Windows.Input;
using CyberApp.Data.Model.Entity;
using CyberApp.Services.Contracts;

namespace CyberApp.View_Model;

public class ClassSelectionViewModel
{
    private readonly IClassService _classService; 
    public ICommand SelectClass { get; set; }
    
    public IEnumerable<CharacterClass> ClassCollection;

    public ClassSelectionViewModel()
    {
        ClassCollection = _classService.GetAll();

        SelectClass = new Command(() =>
        {
            //to do
        });
    }
}