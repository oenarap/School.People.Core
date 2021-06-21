using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class Training : Activity, ITraining
    {
        public string TitleOfTrainingProgram { get; set; }
        public double DurationHours { get; set; }
        public string Sponsor { get; set; }

        public Training()
            : this(Guid.Empty) { }

        public Training(Guid id)
            : this(id, Guid.Empty, null, null, 0d, null, null, false, null) { }

        public Training(Guid id, Guid index, string titleOfTrainingProgram, string sponsor, double durationHours,
            DateTimeOffset? startDate, DateTimeOffset? endDate, bool isOngoing, Guid? locationAddressId)
        {
            Id = id;
            Index = index;
            TitleOfTrainingProgram = titleOfTrainingProgram;
            Sponsor = sponsor;
            DurationHours = durationHours;
            StartDate = startDate;
            EndDate = endDate;
            IsOngoing = isOngoing;
            LocationAddressId = locationAddressId;
        }
    }
}
