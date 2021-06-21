namespace School.People.Core.Attributes
{
    public interface IAgencyMemberDetails : IAttribute
    {
        string AgencyId { get; }
        string GsisIdNumber { get; }
        string PagIbigIdNumber { get; }
        string PhilhealthNumber { get; }
        string SssNumber { get; }
        string Tin { get; }
    }
}
