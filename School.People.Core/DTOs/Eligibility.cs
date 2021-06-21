using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class Eligibility : IndexedAttribute, IEligibility
    {
        public string EligibilityName { get; set; }
        public double Rating { get; set; }
        public DateTimeOffset? DateOfExamOrConferment { get; set; }
        public Guid? PlaceOfExamConferment { get; set; }
        public string LicenseNumberIfApplicable { get; set; }
        public DateTimeOffset? LicenseDateOfRelease { get; set; }

        public Eligibility()
            : this(Guid.Empty) { }

        public Eligibility(Guid id)
            : this(id, Guid.Empty, null, 0.0, null, null, null, null) { }

        public Eligibility(Guid id, Guid index, string eligibilityName, double rating, DateTimeOffset? dateOfExamOrConferment,
            Guid? placeOfExamConferment, string licenseNumberIfApplicable, DateTimeOffset? licenseDateOfRelease)
        {
            Id = id;
            Index = index;
            EligibilityName = eligibilityName;
            Rating = rating;
            DateOfExamOrConferment = dateOfExamOrConferment;
            PlaceOfExamConferment = placeOfExamConferment;
            LicenseNumberIfApplicable = licenseNumberIfApplicable;
            LicenseDateOfRelease = licenseDateOfRelease;
        }
    }
}
