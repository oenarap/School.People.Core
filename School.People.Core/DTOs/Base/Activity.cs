using System;

namespace School.People.Core.DTOs
{
    public abstract record Activity : IndexedAttribute, IActivity
    {
        public DateTimeOffset? StartDate { get; init; }
        public DateTimeOffset? EndDate { get; init; }
        public bool IsOngoing { get; init; }
        public Guid? LocationAddressId { get; init; }
    }
}
