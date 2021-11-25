using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public record CivicWork : Occupation, ICivicWork
    {
        public double TotalHoursWorked { get; init; }
    }
}
