using System;
using School.People.Core.Attributes;

namespace School.People.Core.Dtos
{
    public record Citizenship : Attribute, ICitizenship
    {
        public string DualCitizenshipMode { get; init; }
        public string DualCitizenship { get; init; }
        public string Country { get; init; }
    }
}
