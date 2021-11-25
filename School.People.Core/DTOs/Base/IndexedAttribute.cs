using System;

namespace School.People.Core.DTOs
{
    public abstract record IndexedAttribute : Attribute, IIndexedAttribute
    {
        public Guid Index { get; init; }
    }
}
