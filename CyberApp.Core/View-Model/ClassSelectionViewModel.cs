
using CyberApp.Data.Model.Entity;
using CyberApp.Services.Contracts;
using CyberApp.Services.Implementations;

namespace CyberApp.View_Model;

public class ClassSelectionViewModel
{
    private readonly IServiceProvider _classService; 
    
    public List<CharacterClass> ClassCollection;
    public ClassSelectionViewModel(IServiceProvider classService)
    {
        _classService = classService;
        
        ClassCollection = _classService.GetService<ClassService>().GetAll();
    }
}