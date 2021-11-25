using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public record Education : Attribute, IEducation
    {
        public Guid Index { get; init; }
        public string Level { get; init; }
        public string SchoolName { get; init; }
        public string DegreeCourse { get; init; }
        public string IfGraduatedYearGraduated { get; init; }
        public string IfNotGraduatedHighestLevelOrUnitsEarned { get; init; }
        public DateTimeOffset? StartDate { get; init; }
        public DateTimeOffset? EndDate { get; init; }
        public string ScholarshipOrHonorsReceived { get; init; }
        public bool IsOngoing { get; init; }
    }
}
