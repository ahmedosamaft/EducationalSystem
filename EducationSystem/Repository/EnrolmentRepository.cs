using EducationalSystem.Model.Abstracted;

namespace EducationalSystem.Repository;

public static class EnrolmentRepository
{
    public static SortedSet<IEnrolment> Enrolments { get; set; } = new();
}