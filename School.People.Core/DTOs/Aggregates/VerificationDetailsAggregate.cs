using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs.Aggregates
{
    public record VerificationDetailsAggregate : Attribute, IVerificationDetails, IIdPicture, IThumbPrints
    {
        public byte[] RightThumbmark { get; init; }
        public byte[] LeftThumbmark { get; init; }
        public string CommunityTaxCertificateNumber { get; init; }
        public DateTimeOffset? CommunityTaxCertificateIssuanceDate { get; init; }
        public byte[] RecentPhoto { get; init; }
    }
}
