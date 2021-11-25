using System;

namespace School.People.Core.DTOs
{
    public abstract record Attribute : IAttribute
    {
        public Guid Id { get; init; }
    }
}
