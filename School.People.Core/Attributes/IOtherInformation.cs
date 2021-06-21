namespace School.People.Core.Attributes
{
    public interface IOtherInformation : IIndexedAttribute
    {
        string Category { get; }
        string DescriptiveName { get; }
        string Details { get; }
    }
}
