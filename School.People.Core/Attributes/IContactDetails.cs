using System;

namespace School.People.Core.Attributes
{
    public interface IContactDetails : IAttribute
    {
        string EmailAddress { get; }
        string TelephoneNumber { get; }
        string MobileNumber { get; }
    }
}
