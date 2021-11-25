using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public record PersonDetails : Attribute, IPersonDetails
    {
        public string Sex { get; init; }
        public string CivilStatus { get; init; }
        public string OtherCivilStatus { get; init; }
        public double HeightInCentimeters { get; init; }
        public double WeightInKilograms { get; init; }
        public string BloodType { get; init; }
    }
}
