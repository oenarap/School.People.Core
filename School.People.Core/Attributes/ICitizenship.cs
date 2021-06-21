namespace School.People.Core.Attributes
{
    public interface ICitizenship : IAttribute
    {
        string DualCitizenshipMode { get; }
        string DualCitizenship { get; }
        string Country { get; }
    }
}
