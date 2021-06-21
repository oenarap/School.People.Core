using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class PersonDetails : Attribute, IPersonDetails
    {
        public string Sex { get; set; }
        public string CivilStatus { get; set; }
        public string OtherCivilStatus { get; set; }
        public double HeightInCentimeters { get; set; }
        public double WeightInKilograms { get; set; }
        public string BloodType { get; set; }

        public PersonDetails()
            : this(Guid.Empty) { }

        public PersonDetails(Guid id)
            : this(id, null, null, null, 0.0d, 0.0d, null) { }

        public PersonDetails(Guid id, string sex, string civilStatus, string otherCivilStatus, 
            double heightInCentimeter, double weightInKilograms, string bloodType) {
            Id = id;
            Sex = sex;
            CivilStatus = civilStatus;
            OtherCivilStatus = otherCivilStatus;
            HeightInCentimeters = heightInCentimeter;
            WeightInKilograms = weightInKilograms;
            BloodType = bloodType;
        }
    }
}
