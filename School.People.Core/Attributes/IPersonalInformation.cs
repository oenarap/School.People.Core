using System;

namespace School.People.Core.Attributes
{
    public interface IPersonalInformation : IAttribute
    {
        string Sex { get; }
        string CivilStatus { get; }
        string OtherCivilStatus { get; }
        string DualCitizenshipMode { get; }
        string DualCitizenship { get; }
        string Country { get; }
        double HeightInCentimeters { get; }
        double WeightInKilograms { get; }
        string BloodType { get; }
        string GsisIdNumber { get; }
        string PagIbigIdNumber { get; }
        string PhilhealthNumber { get; }
        string SssNumber { get; }
        string Tin { get; }
    }
}
