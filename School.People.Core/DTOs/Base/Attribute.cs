using System;

namespace School.People.Core.DTOs
{
    public abstract class Attribute : IAttribute
    {
        public Guid Id { get; set; }
    }
}
