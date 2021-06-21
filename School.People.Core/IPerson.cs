using System;

namespace School.People.Core
{
    public interface IPerson : IDataEntity
    {
        string LastName { get; }
        string FirstName { get; }
        string MiddleName { get; }
        string NameExtension { get; }
        string Title { get; }
    }
}
