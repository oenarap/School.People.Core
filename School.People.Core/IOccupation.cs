namespace School.People.Core
{
    public interface IOccupation
    {
        string PositionTitle { get; }
        string EmployerOrganizationOrBusinessName { get; }
        string TelephoneNumber { get; }
    }
}
