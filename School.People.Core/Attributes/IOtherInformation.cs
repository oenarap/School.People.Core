namespace School.People.Core.Attributes
{
    public interface IOtherInformation : IAttribute
    {
        string Category { get; }
        string DescriptiveName { get; }
        string Details { get; }
    }
}
