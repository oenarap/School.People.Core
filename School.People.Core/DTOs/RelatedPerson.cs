using System;
using System.Collections.Generic;
using System.Text;

namespace School.People.Core.Dtos
{
    public record RelatedPerson : Person, IRelatedPerson
    {
        public Relationship Relationship { get; init; }
    }
}
