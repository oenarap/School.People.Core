using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class DateOfBirth : Attribute, IDateOfBirth
    {
        public DateTimeOffset? Birthdate { get; set; }

        public DateOfBirth()
            : this(Guid.Empty) { }

        public DateOfBirth(Guid id)
            : this(id, null) { }

        public DateOfBirth(Guid id, DateTimeOffset? birthdate)
        {
            Id = id;
            Birthdate = birthdate;
        }
    }
}
