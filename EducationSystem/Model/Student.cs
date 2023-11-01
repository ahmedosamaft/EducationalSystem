using EducationalSystem.Model.Abstracted;

namespace EducationalSystem.Model;

public class Student(string id, string password, string firstName, string lastName, DateTime dateOfBirth, decimal? gpa)
    : IStudent
{
    public string Id { get; set; } = id;
    public string Password { get; set; } = password;
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public DateTime DateOfBirth { get; set; } = dateOfBirth;
    
    public decimal? Gpa { get; set; } = gpa;

    public Student(string id) : this(id, null, null, null, new DateTime(), null) { }
    

    public void GetEnrolledCourses()
    {
        throw new NotImplementedException();
    }

    public void SubmitAssignment(string assignmentId, string course, string submission)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{{\n\tId: {Id},\n\tName: {FirstName + " " + LastName}}}";
    }

    public int CompareTo(object? obj)
    {
        var student = obj as Student ?? throw new ArgumentException("Object must be student");
        return String.Compare(Id, student.Id, StringComparison.Ordinal);
    }

    protected bool Equals(Student other)
    {
        return Id == other.Id;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Student)obj);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public static bool operator ==(Student? left, Student? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Student? left, Student? right)
    {
        return !Equals(left, right);
    }
}