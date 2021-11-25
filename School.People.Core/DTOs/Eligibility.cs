using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public record Eligibility : IndexedAttribute, IEligibility
    {
        public string EligibilityName { get; init; }
        public double Rating { get; init; }
        public DateTimeOffset? DateOfExamOrConferment { get; init; }
        public Guid? PlaceOfExamConferment { get; init; }
        public string LicenseNumberIfApplicable { get; init; }
        public DateTimeOffset? LicenseDateOfRelease { get; init; }
    }
}
