using EducationalSystem.Model.Abstracted;

namespace EducationalSystem.Model;

public class Course(string courseName, string courseCode, int credits, IDoctor? doctor)
    : ICourse
{
    public string CourseName { get; set; } = courseName;
    public string CourseCode { get; set; } = courseCode;
    public int Credits { get; set; } = credits;
    public IDoctor? Doctor { get; set; } = doctor;

    public override string ToString()
    {
        return $"{{\n\tCourse Code: {CourseCode},\n\tName: {CourseName},\n\tCredits: {Credits}\n}}";
    }

    protected bool Equals(Course other)
    {
        return CourseName == other.CourseName && CourseCode == other.CourseCode;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Course)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(CourseName, CourseCode);
    }

    public int CompareTo(object? obj)
    {
        var course = obj as Course ?? throw new ArgumentException("Object must be course");
        return courseCode.CompareTo(course.CourseCode);
    }

    public static bool operator ==(Course? left, Course? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Course? left, Course? right)
    {
        return !Equals(left, right);
    }
}