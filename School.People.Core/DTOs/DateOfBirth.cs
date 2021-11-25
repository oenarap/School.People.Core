using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public record DateOfBirth : Attribute, IDateOfBirth
    {
        public DateTimeOffset? Birthdate { get; init; }
    }
}
