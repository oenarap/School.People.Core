using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class Education : Attribute, IEducation
    {
        public Guid Index { get; set; }
        public string Level { get; set; }
        public string SchoolName { get; set; }
        public string DegreeCourse { get; set; }
        public string IfGraduatedYearGraduated { get; set; }
        public string IfNotGraduatedHighestLevelOrUnitsEarned { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public string ScholarshipOrHonorsReceived { get; set; }
        public bool IsOngoing { get; set; }

        public Education()
            : this(Guid.Empty) { }

        public Education(Guid id)
            : this(id, Guid.Empty, null, null, null, null, null, null, null,false, null) { }

        public Education(Guid id, Guid index, string level, string schoolName, string course, string ifGraduatedYearGraduated, string ifNotGraduatedHighestLevelOrUnitsEarned,
            DateTimeOffset? startDate, DateTimeOffset? endDate, bool isOngoing, string scholarshipOrHonorsReceived) {
            Id = id;
            Index = index;
            IsOngoing = isOngoing;
            Level = level;
            SchoolName = schoolName;
            DegreeCourse = course;
            IfGraduatedYearGraduated = ifGraduatedYearGraduated;
            IfNotGraduatedHighestLevelOrUnitsEarned = ifNotGraduatedHighestLevelOrUnitsEarned;
            ScholarshipOrHonorsReceived = scholarshipOrHonorsReceived;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
