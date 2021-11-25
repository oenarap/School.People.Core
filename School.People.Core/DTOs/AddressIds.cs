using System;
using School.People.Core.Attributes;

namespace School.People.Core.Dtos
{
    public record AddressIds : Attribute, IAddressIds
    {
        public Guid? BirthAddressId { get; init; }
        public Guid? ResidentialAddressId { get; init; }
        public Guid? PermanentAddressId { get; init; }
        public Guid? BusinessAddressId { get; init; }
        public Guid? CommunityTaxCertificateIssuanceAddressId { get; init; }
    }
}
