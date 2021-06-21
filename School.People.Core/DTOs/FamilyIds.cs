using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class FamilyIds : Attribute, IFamilyIds
    {
        public Guid? MotherId { get; set; }
        public Guid? FatherId { get; set; }
        public Guid? SpouseId { get; set; }

        public FamilyIds()
            : this(Guid.Empty) { }

        public FamilyIds(Guid id)
            : this(id, null, null, null) { }

        public FamilyIds(Guid id, Guid? motherId, Guid? fatherId, Guid? spouseId)
        {
            Id = id;
            MotherId = motherId;
            FatherId = fatherId;
            SpouseId = spouseId;
        }
    }
}
