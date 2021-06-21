using System;

namespace School.People.Core.Attributes
{
    public interface IEducation : IAttribute
    {
        string Level { get; }
        string SchoolName { get; }
        string DegreeCourse { get; }
        int IfGraduatedYearGraduated { get; }
        string IfNotGraduatedHighestLevelOrUnitsEarned { get; }
        DateTimeOffset? StartDate { get; }
        DateTimeOffset? EndDate { get; }
        string ScholarshipOrHonorsReceived { get; }
        bool IsOngoing { get; }
    }
}
