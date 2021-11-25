using System;
using School.People.Core.Attributes;

namespace School.People.Core.Dtos.Aggregates
{

    public record PersonalInformationAggregate : Attribute, IDateOfBirth, 
        ICitizenship, IPersonDetails, IAgencyMemberDetails, IContactDetails
    {
        public object BirthAddress { get; init; }
        public object ResidentialAddress { get; init; }
        public object PermanentAddress { get; init; }
        public DateTimeOffset? Birthdate { get; init; }
        public string DualCitizenshipMode { get; init; }
        public string DualCitizenship { get; init; }
        public string Country { get; init; }
        public string Sex { get; init; }
        public string CivilStatus { get; init; }
        public string OtherCivilStatus { get; init; }
        public double HeightInCentimeters { get; init; }
        public double WeightInKilograms { get; init; }
        public string BloodType { get; init; }
        public string AgencyId { get; init; }
        public string GsisIdNumber { get; init; }
        public string PagIbigIdNumber { get; init; }
        public string PhilhealthNumber { get; init; }
        public string SssNumber { get; init; }
        public string Tin { get; init; }
        public string EmailAddress { get; init; }
        public string TelephoneNumber { get; init; }
        public string MobileNumber { get; init; }
    }
}
