using System;

namespace School.People.Core.Dtos
{
    public abstract record Attribute : IAttribute
    {
        public Guid Id { get; init; }
    }
}
