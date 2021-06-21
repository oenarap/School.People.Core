namespace School.People.Core.Attributes
{
    public interface ICivicWork : IAttribute, IActivity, IOccupation
    {
        float TotalHoursWorked { get; }
    }
}
