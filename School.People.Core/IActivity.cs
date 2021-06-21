using System;

namespace School.People.Core
{
    public interface IActivity
    {
        DateTimeOffset? StartDate { get; }
        DateTimeOffset? EndDate { get; }
        bool IsOngoing { get; }
        Guid? LocationAddressId { get; }
    }
}
