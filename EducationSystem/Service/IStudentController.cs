using EducationalSystem.Model;
using EducationalSystem.Model.Abstracted;

namespace EducationalSystem.Controller.Characters;

public interface IStudentController : IPersonController
{
    IStudent CreateStudent(string firstName,string lastName,string password,DateTime dateOfBirth,decimal? gpa);
    Enrolment Enroll(IStudent student, Course course);
}