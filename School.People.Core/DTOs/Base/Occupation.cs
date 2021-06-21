namespace School.People.Core.DTOs
{
    public abstract class Occupation : Activity, IOccupation
    {
        public string PositionTitle { get; set; }
        public string EmployerOrganizationOrBusinessName { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
