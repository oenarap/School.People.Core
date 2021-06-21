namespace School.People.Core.Attributes
{
    public interface ITraining : IAttribute, IActivity
    {
        string TitleOfTrainingProgram { get; }
        double DurationHours { get; }
        string Sponsor { get; }
    }
}
