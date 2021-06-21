namespace School.People.Core.Attributes
{
    public interface IRegularWork : IAttribute, IActivity, IOccupation
    {
        double MonthlySalary { get; }
        string SalaryGradeAndStepIncrement { get; }
        string StatusOfAppointment { get; }
        bool IsGovernmentService { get; }
    }
}
