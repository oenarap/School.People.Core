using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class AddressIds : Attribute, IAddressIds
    {
        public Guid? BirthAddressId { get; set; }
        public Guid? ResidentialAddressId { get; set; }
        public Guid? PermanentAddressId { get; set; }
        public Guid? BusinessAddressId { get; set; }
        public Guid? CommunityTaxCertificateIssuanceAddressId { get; set; }

        public AddressIds()
            : this(Guid.Empty) { }

        public AddressIds(Guid id)
            : this(id, null, null, null, null, null) { }

        public AddressIds(Guid id, Guid? birthAddressId, Guid? residentialAddressId, Guid? permanentAddressId, 
            Guid? businessAddressId, Guid? communityTaxCertificateIssuanceAddressId)
        {
            Id = id;
            BirthAddressId = birthAddressId;
            ResidentialAddressId = residentialAddressId;
            PermanentAddressId = permanentAddressId;
            BusinessAddressId = businessAddressId;
            CommunityTaxCertificateIssuanceAddressId = communityTaxCertificateIssuanceAddressId;
        }
    }
}
