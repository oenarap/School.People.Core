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

        public VerificationDetailsAggregate(Guid id)
            : this(id, null, null, null, null, null) { }

        public VerificationDetailsAggregate(Guid id, string ctcNumber, DateTimeOffset? ctcDate, byte[] recentPhoto, byte[] rightThumbmark, byte[] leftThumbmark)
        {
            Id = id;
            CommunityTaxCertificateNumber = ctcNumber;
            CommunityTaxCertificateIssuanceDate = ctcDate;
            RecentPhoto = recentPhoto;
            RightThumbmark = rightThumbmark;
            LeftThumbmark = leftThumbmark;
        }
    }
}
