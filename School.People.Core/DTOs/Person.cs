using System;
using System.Runtime.Serialization;

namespace School.People.Core.Dtos
{
    /// <summary>
    /// A data transfer object for
    /// any <see cref="IPerson"/> implementation.
    /// </summary>
    public record Person : IPerson
    {
        public Guid Id { get; init; }
        public string LastName { get; init; }
        public string FirstName { get; init; }
        public string MiddleName { get; init; }
        public string NameExtension { get; init; }
        public string Title { get; init; }
    }
}
