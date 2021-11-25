using System;
using System.Collections.Generic;
using System.Text;

namespace School.People.Core.DTOs
{
    public record RelatedPerson : Person, IRelatedPerson
    {
        public Relationship Relationship { get; init; }
    }
}
