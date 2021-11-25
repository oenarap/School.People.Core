namespace School.People.Core.Dtos
{
    public abstract record Occupation : Activity, IOccupation
    {
        public string PositionTitle { get; init; }
        public string EmployerOrganizationOrBusinessName { get; init; }
        public string TelephoneNumber { get; init; }
    }
}
