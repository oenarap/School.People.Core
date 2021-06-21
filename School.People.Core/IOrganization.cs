using System;
using School.People.Core.Attributes;

namespace School.People.Core
{
    public interface IOrganization
    {
        Guid Id { get; }
        string Name { get; }
        string NatureOfBusiness { get; }
        IContactDetails ContactDetails { get; }
    }
}
