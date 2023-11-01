using EducationalSystem.Controller.Managerial;
using EducationalSystem.Model;
using EducationalSystem.Model.Abstracted;

namespace EducationSystem.Service.Managerial;

public class EnrolmentController : IEnrolmentController
{
    public Enrolment Add(IStudent student, Course course)
    {
        throw new NotImplementedException();
        // DateTime currentDateTime = DateTime.Now;
        // DateTime yearMonthOnly = new DateTime(currentDateTime.Year, currentDateTime.Month, 1);
        // Enrolment enrolment = new Enrolment(student, course, yearMonthOnly);
        // EnrolmentRepository.Enrolments.Add(enrolment);
        // return enrolment;
    }

    public bool Drop(IStudent student, Course course, DateTime dateTime)
    {
        throw new NotImplementedException();
        // DateTime yearMonthOnly = new DateTime(dateTime.Year, dateTime.Month, 1);
        // return EnrolmentRepository.Enrolments.Remove(new Enrolment(student, course, yearMonthOnly));
    }
}