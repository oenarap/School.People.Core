using System;
using School.People.Core.Attributes;

namespace School.People.Core.Dtos
{
    public record FamilyIds : Attribute, IFamilyIds
    {
        public Guid? MotherId { get; init; }
        public Guid? FatherId { get; init; }
        public Guid? SpouseId { get; init; }
    }
}
