using System;
using System.Collections.Generic;
using System.Text;

namespace School.People.Core.DTOs.Aggregates
{
    public class FamilyMembersAggregate : Attribute
    {
        public IPerson Mother { get; set; }
        public IPerson Father { get; set; }
        public IPerson Spouse { get; set; }
        public IEnumerable<IPerson> Children { get; set; }

        public FamilyMembersAggregate()
            : this(Guid.Empty) { }

        public FamilyMembersAggregate(Guid id)
            : this(id, null, null, null, null) { }

        public FamilyMembersAggregate(Guid id, IPerson mother, IPerson father, IPerson spouse, IEnumerable<IPerson> children)
        {
            Id = id;
            Mother = mother;
            Father = father;
            Spouse = spouse;
            Children = children;
        }
    }
}
