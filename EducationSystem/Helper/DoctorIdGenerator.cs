namespace EducationalSystem.Helper;

public class DoctorIdGenerator : IIdGenerator
{
    public long Counter { get; private set; }

    public string GenerateUniqueId()
    {
        ++Counter;
        return $"s{Counter:0000}";
    }
}