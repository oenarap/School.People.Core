using System.Collections.Generic;

namespace School.People.Core.Attributes.Aggregates
{
    public interface IFamilyMembersAggregate : IAttribute
    {
        IPerson Mother { get; }
        IPerson Father { get; }
        IPerson Spouse { get; }
        IEnumerable<IPerson> Children { get; }
    }
}
