namespace School.People.Core.Attributes
{
    public interface ICivicWork : IIndexedAttribute, IActivity, IOccupation
    {
        double TotalHoursWorked { get; }
    }
}
