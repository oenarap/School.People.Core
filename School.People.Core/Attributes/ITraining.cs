namespace School.People.Core.Attributes
{
    public interface ITraining : IIndexedAttribute, IActivity
    {
        string TitleOfTrainingProgram { get; }
        double DurationHours { get; }
        string Sponsor { get; }
    }
}
