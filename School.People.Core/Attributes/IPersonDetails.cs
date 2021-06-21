namespace School.People.Core.Attributes
{
    public interface IPersonDetails : IAttribute
    {
        string Sex { get; }
        string CivilStatus { get; }
        string OtherCivilStatus { get; }
        double HeightInCentimeters { get; }
        double WeightInKilograms { get; }
        string BloodType { get; }
    }
}
