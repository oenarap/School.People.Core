using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class ContactDetails : Attribute, IContactDetails
    {
        public string EmailAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public string MobileNumber { get; set; }

        public ContactDetails()
            : this(Guid.Empty) { }

        public ContactDetails(Guid id)
            : this(id, null, null, null) { }

        public ContactDetails(Guid id, string emailAddress, string telephoneNumber, string mobileNumber)
        {
            Id = id;
            EmailAddress = emailAddress;
            TelephoneNumber = telephoneNumber;
            MobileNumber = mobileNumber;
        }
    }
}
