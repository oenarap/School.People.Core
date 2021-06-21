namespace School.People.Core.Attributes.Aggregates
{
    public interface IPersonalInformationAggregate : IAttribute, IDateOfBirth, ICitizenship, IPersonDetails, IAgencyMemberDetails, IContactDetails
    {
        object BirthAddress { get; }
        object ResidentialAddress { get; }
        object PermanentAddress { get; }
    }
}
