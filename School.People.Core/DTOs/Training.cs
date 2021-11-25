using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public record Training : Activity, ITraining
    {
        public string TitleOfTrainingProgram { get; init; }
        public double DurationHours { get; init; }
        public string Sponsor { get; init; }
    }
}
