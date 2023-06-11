using CyberApp.Data.Model.Entity;

namespace CyberApp.Services.Contracts;

public interface IClassService
{
    List<CharacterClass> GetAll();
}