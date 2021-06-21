using System;

namespace School.People.Core
{
    public interface IPerson
    {
        Guid Id { get; }
        string LastName { get; }
        string FirstName { get; }
        string MiddleName { get; }
        string NameExtension { get; }
        string Title { get; }
    }
}
