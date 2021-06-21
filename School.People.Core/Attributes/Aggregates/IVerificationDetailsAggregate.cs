namespace School.People.Core.Attributes.Aggregates
{
    public interface IVerificationDetailsAggregate : IAttribute
    {
        IVerificationDetails VerificationDetails { get; }
        byte[] RecentPhoto { get; }
        byte[] RightThumbmark { get; }
        byte[] LeftThumbmark { get; }
    }
}
