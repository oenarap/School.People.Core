using System;
using School.People.Core.Attributes;

namespace School.People.Core.Dtos
{
    public record Work : Occupation, IWork
    {
        public decimal MonthlySalary { get; init; }
        public string SalaryGradeAndStepIncrement { get; init; }
        public string StatusOfAppointment { get; init; }
        public bool IsGovernmentService { get; init; }
    }
}
