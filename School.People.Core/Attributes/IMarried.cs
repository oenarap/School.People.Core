using System;

namespace School.People.Core.Attributes
{
    public interface IMarried : IAttribute
    {
        Guid? SpouseId { get; }
    }
}
