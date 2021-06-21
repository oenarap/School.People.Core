using System;
using System.Runtime.Serialization;

namespace School.People.Core.DTOs
{
    /// <summary>
    /// A data transfer object for
    /// any <see cref="IPerson"/> implementation.
    /// </summary>
    public class Person : IPerson
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string NameExtension { get; set; }

        public Person()
            : this(Guid.Empty) { }

        public Person(Guid id) 
            : this(id, null, null, null, null, null) { }

        public Person(string lastName, string firstName, string middleName, string nameExtension, string title) 
            : this(Guid.Empty, lastName, firstName, middleName, nameExtension, title) { }

        public Person(Guid id, string lastName, string firstName, string middleName, string nameExtension, string title)
        {
            Id = id;
            Title = title;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            NameExtension = nameExtension;
        }
    }
}
