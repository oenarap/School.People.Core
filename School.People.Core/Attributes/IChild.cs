using System;

namespace School.People.Core.Attributes
{
    public interface IChild : IAttribute
    {
        Guid? MotherId { get; }
        Guid? FatherId { get; }
    }
}
