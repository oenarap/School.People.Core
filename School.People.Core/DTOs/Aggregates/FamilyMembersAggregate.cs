using System;
using System.Collections.Generic;
using System.Text;

namespace School.People.Core.DTOs.Aggregates
{
    public record FamilyMembersAggregate : Attribute
    {
        public IPerson Mother { get; init; }
        public IPerson Father { get; init; }
        public IPerson Spouse { get; init; }
        public IEnumerable<IPerson> Children { get; init; }
    }
}
