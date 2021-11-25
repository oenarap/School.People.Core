using System;
using School.People.Core.Attributes;

namespace School.People.Core.Dtos
{
    public record DateOfBirth : Attribute, IDateOfBirth
    {
        public DateTimeOffset? Birthdate { get; init; }
    }
}
