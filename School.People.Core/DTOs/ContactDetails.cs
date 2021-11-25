using System;
using School.People.Core.Attributes;

namespace School.People.Core.Dtos
{
    public record ContactDetails : Attribute, IContactDetails
    {
        public string EmailAddress { get; init; }
        public string TelephoneNumber { get; init; }
        public string MobileNumber { get; init; }
    }
}
