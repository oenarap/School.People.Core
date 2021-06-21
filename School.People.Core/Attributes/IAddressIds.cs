using System;

namespace School.People.Core.Attributes
{
    public interface IAddressIds : IAttribute
    {
        Guid? BirthAddressId { get; }
        Guid? ResidentialAddressId { get; }
        Guid? PermanentAddressId { get; }
        Guid? BusinessAddressId { get; }
        Guid? CommunityTaxCertificateIssuanceAddressId { get; }
    }
}
