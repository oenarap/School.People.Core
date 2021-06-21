using System;

namespace School.People.Core.Attributes
{
    public interface IEligibility : IAttribute
    {
        string EligibilityName { get; }
        double Rating { get; }
        DateTimeOffset? DateOfExamOrConferment { get; }
        Guid? PlaceOfExamConferment { get; }
        string LicenseNumberIfApplicable { get; }
        DateTimeOffset? LicenseDateOfRelease { get; }
    }
}
