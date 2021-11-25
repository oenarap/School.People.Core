using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public record OtherInformation : IndexedAttribute, IOtherInformation
    {
        public string Category { get; init; }
        public string DescriptiveName { get; init; }
        public string Details { get; init; }
    }
}
