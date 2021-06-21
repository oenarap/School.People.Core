using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class CivicWork : Occupation, ICivicWork
    {
        public double TotalHoursWorked { get; set; }

        public CivicWork()
            : this(Guid.Empty) { }

        public CivicWork(Guid id)
            : this(id, Guid.Empty, null, null, null, null, null, false, null, 0d) { }

        public CivicWork(Guid id, Guid index, string positionTitle, string employerOrganizationOrBusinessName, string telephoneNumber,
            DateTimeOffset? startDate, DateTimeOffset? endDate, bool isOngoing, Guid? locationAddressId, double totalHoursWorked)
        {
            Id = id;
            Index = index;
            PositionTitle = positionTitle;
            EmployerOrganizationOrBusinessName = employerOrganizationOrBusinessName;
            TelephoneNumber = telephoneNumber;
            StartDate = startDate;
            EndDate = endDate;
            IsOngoing = isOngoing;
            LocationAddressId = locationAddressId;
            TotalHoursWorked = totalHoursWorked;
        }
    }
}
