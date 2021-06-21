using System;

namespace School.People.Core.Attributes
{
    public interface IFamilyIds : IAttribute
    {
        Guid? MotherId { get; }
        Guid? FatherId { get; }
        Guid? SpouseId { get; }
    }
}
