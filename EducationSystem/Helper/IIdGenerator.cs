namespace EducationalSystem.Helper;

public interface IIdGenerator
{
    public long Counter { get; }
    string GenerateUniqueId();
}