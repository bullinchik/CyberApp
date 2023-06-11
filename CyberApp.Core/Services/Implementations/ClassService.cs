using CyberApp.Data;
using CyberApp.Data.Model.Entity;
using CyberApp.Services.Contracts;

namespace CyberApp.Services.Implementations;

public class ClassService : IClassService
{
    private readonly DatabaseContext _context;

    public ClassService(DatabaseContext context)
    {
        _context = context;
    }
    
    public List<CharacterClass> GetAll()
    {
        return _context.CharacterClasses.ToList();
    }
}