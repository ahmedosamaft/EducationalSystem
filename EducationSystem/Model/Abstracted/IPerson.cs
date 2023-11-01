namespace EducationalSystem.Model;

public interface IPerson : IComparable
{
    string Id { get; set; }
    string Password { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    DateTime DateOfBirth { get; set; }
}