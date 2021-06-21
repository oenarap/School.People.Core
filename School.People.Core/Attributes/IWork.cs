namespace School.People.Core.Attributes
{
    public interface IWork : IIndexedAttribute, IActivity, IOccupation
    {
        decimal MonthlySalary { get; }
        string SalaryGradeAndStepIncrement { get; }
        string StatusOfAppointment { get; }
        bool IsGovernmentService { get; }
    }
}
