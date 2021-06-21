using System;

namespace School.People.Core.Attributes
{
    public interface IEducation : IIndexedAttribute
    {
        string Level { get; }
        string SchoolName { get; }
        string DegreeCourse { get; }
        string IfGraduatedYearGraduated { get; }
        string IfNotGraduatedHighestLevelOrUnitsEarned { get; }
        DateTimeOffset? StartDate { get; }
        DateTimeOffset? EndDate { get; }
        string ScholarshipOrHonorsReceived { get; }
        bool IsOngoing { get; }
    }
}
