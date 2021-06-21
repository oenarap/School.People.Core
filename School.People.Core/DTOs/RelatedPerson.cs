using System;
using System.Collections.Generic;
using System.Text;

namespace School.People.Core.DTOs
{
    public class RelatedPerson : Person, IRelatedPerson
    {
        public Relationship? Relationship { get; set; }

        public RelatedPerson()
            : this(Guid.Empty, null) { }

        public RelatedPerson(Guid id, Relationship? relationship)
            : this(id, null, null, null, null, null, relationship) { }

        public RelatedPerson(string lastName, string firstName, string middleName, string nameExtension, string title, Relationship? relationship)
            : this(Guid.Empty, lastName, firstName, middleName, nameExtension, title, relationship) { }

        public RelatedPerson(Guid id, string lastName, string firstName, string middleName, string nameExtension, string title, Relationship? relationship)
            : base(id, lastName, firstName, middleName, nameExtension, title) { Relationship = relationship; }
    }
}
