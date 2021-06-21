using System;

namespace School.People.Core.DTOs
{
    public abstract class Activity : IndexedAttribute, IActivity
    {
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public bool IsOngoing { get; set; }
        public Guid? LocationAddressId { get; set; }
    }
}
