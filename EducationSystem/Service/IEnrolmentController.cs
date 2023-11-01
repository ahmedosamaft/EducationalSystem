using EducationalSystem.Model;
using EducationalSystem.Model.Abstracted;
using EducationalSystem.Repository;

namespace EducationalSystem.Controller.Managerial;

public interface IEnrolmentController
{
    Enrolment Add(IStudent student, Course course);
    bool Drop(IStudent student, Course course, DateTime dateTime);
}