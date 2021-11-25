using System;

namespace School.People.Core.Dtos
{
    public abstract record IndexedAttribute : Attribute, IIndexedAttribute
    {
        public Guid Index { get; init; }
    }
}
