using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs.Aggregates
{
    public class VerificationDetailsAggregate : Attribute, IVerificationDetails, IIdPicture, IThumbPrints
    {
        public byte[] RightThumbmark { get; set; }
        public byte[] LeftThumbmark { get; set; }
        public string CommunityTaxCertificateNumber { get; set; }
        public DateTimeOffset? CommunityTaxCertificateIssuanceDate { get; set; }
        public byte[] RecentPhoto { get; set; }
    }
}
