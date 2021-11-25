namespace School.People.Core.DTOs
{
    public abstract record Occupation : Activity, IOccupation
    {
        public string PositionTitle { get; init; }
        public string EmployerOrganizationOrBusinessName { get; init; }
        public string TelephoneNumber { get; init; }
    }
}
