using EducationalSystem.Model;

namespace EducationalSystem.Controller.Characters;

public interface IPersonController
{
    SortedDictionary<string, IPerson> IdPerson { get; set; }
    IPerson? Login(string id, string password);
    IPerson? GetPerson(string id);
    void AddPerson(IPerson person);
    void RemovePerson(IPerson person);
}