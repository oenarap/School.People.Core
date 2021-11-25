using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public record VerificationDetails : Attribute, IVerificationDetails
    {
        public string CommunityTaxCertificateNumber { get; init; }
        public DateTimeOffset? CommunityTaxCertificateIssuanceDate { get; init; }
    }
}
