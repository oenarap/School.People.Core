using System;

namespace School.People.Core.DTOs
{
    public abstract class IndexedAttribute : Attribute, IIndexedAttribute
    {
        public Guid Index { get; set; }
    }
}
