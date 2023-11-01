using EducationalSystem.Controller.Managerial;
using EducationalSystem.Helper;
using EducationalSystem.Model;
using EducationalSystem.Model.Abstracted;
using EducationSystem.Service.Managerial;

namespace EducationalSystem.Controller.Characters;

public class StudentController : IStudentController
{
    private readonly StudentIdGenerator _idGenerator = new StudentIdGenerator();
    private readonly EnrolmentController _enrolmentController = new();
    public SortedDictionary<string, IPerson> IdPerson { get; set; } = new();

    public IPerson? Login(string id, string password)
    {
        return IdPerson.TryGetValue(id, out IPerson? value) && value.Password == password ? value : null;
    }

    public IPerson? GetPerson(string id)
    {
        return IdPerson.TryGetValue(id, out IPerson? value) ? value : null;
    }

    public void AddPerson(IPerson person)
    {
        IdPerson.TryAdd(person.Id, person);
    }

    public void RemovePerson(IPerson person)
    {
        IdPerson.Remove(person.Id);
    }

    public IStudent CreateStudent(string firstName, string lastName, string password, DateTime dateOfBirth,
        decimal? gpa)
    {
        IStudent student =
            new Student(_idGenerator.GenerateUniqueId(), password, firstName, lastName, dateOfBirth, gpa);
        AddPerson(student);
        return student;
    }

    public Enrolment Enroll(IStudent student, Course course)
    {
        throw new NotImplementedException();
    }
}