namespace EducationalSystem.Model.Abstracted;

public interface IStudent : IPerson
{
    decimal? Gpa { get; set; }
    void GetEnrolledCourses();
    void SubmitAssignment(string assignmentId, string course,string submission);
}