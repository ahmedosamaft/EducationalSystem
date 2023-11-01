using EducationalSystem.Model.Abstracted;

namespace EducationalSystem.Model;

public class Enrolment(IStudent student, ICourse course, DateTime enrolDate) : IEnrolment
{
    public IStudent Student { get; set; } = student;
    public ICourse Course { get; set; } = course;
    public DateTime EnrolDate { get; set; } = enrolDate;

    public int CompareTo(object? obj)
    {
        var enrol = obj as Enrolment ?? throw new ArgumentException("Object must be Enrollment");
        if (!Equals(enrol.Student, Student))
            return Student.CompareTo(enrol.Student);
        if (!Equals(Course, enrol.Course))
            return Course.CompareTo(enrol.Course);
        return DateTime.Compare(EnrolDate, enrol.EnrolDate);
    }

    protected bool Equals(Enrolment other)
    {
        return Student.Equals(other.Student) && Course.Equals(other.Course) && EnrolDate.Equals(other.EnrolDate);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Enrolment)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Student, Course, EnrolDate);
    }

    public static bool operator ==(Enrolment? left, Enrolment? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Enrolment? left, Enrolment? right)
    {
        return !Equals(left, right);
    }
}