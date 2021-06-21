namespace School.People.Core.Attributes
{
    public interface IMaidenName : IAttribute
    {
        string MaidenLastName { get; }
        string MaidenMiddleName { get; }
    }
}
