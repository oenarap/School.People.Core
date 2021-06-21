using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class VerificationDetails : Attribute, IVerificationDetails
    {
        public string CommunityTaxCertificateNumber { get; set; }
        public DateTimeOffset? CommunityTaxCertificateIssuanceDate { get; set; }

        public VerificationDetails()
            : this(Guid.Empty) { }

        public VerificationDetails(Guid id)
            : this(id, null, null) { }

        public VerificationDetails(Guid id, string communityTaxCertificateNumber, DateTimeOffset? communityTaxCertificateIssuanceDate)
        {
            Id = id;
            CommunityTaxCertificateNumber = communityTaxCertificateNumber;
            CommunityTaxCertificateIssuanceDate = communityTaxCertificateIssuanceDate;
        }
    }
}
