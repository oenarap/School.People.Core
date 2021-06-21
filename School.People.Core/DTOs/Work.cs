using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class Work : Occupation, IWork
    {
        public decimal MonthlySalary { get; set; }
        public string SalaryGradeAndStepIncrement { get; set; }
        public string StatusOfAppointment { get; set; }
        public bool IsGovernmentService { get; set; }

        public Work()
            : this(Guid.Empty) { }

        public Work(Guid id)
            : this(id, Guid.Empty, null, null, null, 0m, null, null, false, null, null, false, null) { }

        public Work(Guid id, Guid index, string positionTitle, string employerOrganizationOrBusinessName, string telephoneNumber,
            decimal monthlySalary, string salaryGradeAndStepIncrement, string statusOfAppointment, bool isGovernmentService,
            DateTimeOffset? startDate, DateTimeOffset? endDate, bool isOngoing, Guid? locationAddressId)
        {
            Id = id;
            Index = index;
            PositionTitle = positionTitle;
            EmployerOrganizationOrBusinessName = employerOrganizationOrBusinessName;
            TelephoneNumber = telephoneNumber;
            MonthlySalary = monthlySalary;
            SalaryGradeAndStepIncrement = salaryGradeAndStepIncrement;
            StatusOfAppointment = statusOfAppointment;
            IsGovernmentService = isGovernmentService;
            StartDate = startDate;
            EndDate = endDate;
            IsOngoing = isOngoing;
            LocationAddressId = locationAddressId;
        }
    }
}
