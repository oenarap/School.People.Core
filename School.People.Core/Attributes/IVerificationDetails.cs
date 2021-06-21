using System;

namespace School.People.Core.Attributes
{
    public interface IVerificationDetails : IAttribute
    {
        string CommunityTaxCertificateNumber { get; }
        DateTimeOffset? CommunityTaxCertificateIssuanceDate { get; }
    }
}
