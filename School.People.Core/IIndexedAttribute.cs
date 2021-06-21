using System;

namespace School.People.Core
{
    public interface IIndexedAttribute : IAttribute
    {
        Guid Index { get; }
    }
}
