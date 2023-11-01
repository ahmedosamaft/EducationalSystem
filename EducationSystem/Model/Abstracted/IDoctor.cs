namespace EducationalSystem.Model;

public interface IDoctor : IPerson
{
    List<string> GetTeachingCourses();
    void AddAssignment();
    void GiveGrade(string assignment, string course, decimal grade);
    void TeachCourse(string course);
}