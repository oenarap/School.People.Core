using System;

namespace School.People.Core.Attributes
{
    public interface IFaqs : IAttribute
    {
        bool IsRelatedToAuthorityThirdDegree { get; }
        bool IsRelatedToAuthorityFourthDegree { get; }
        string RelationshipToAuthorityDetails { get; }
        bool IsGuiltyOfAdministrativeOffense { get; }
        string AdministrativeOffenseDetails { get; }
        bool WasCriminallyCharged { get; }
        DateTimeOffset? CriminalChargesFilingDate { get; }
        string CriminalChargesCaseStatus { get; }
        bool WasConvicted { get; }
        string ConvictionDetails { get; }
        bool WasSeparatedFromService { get; }
        string SeparationFromServiceDetails { get; }
        bool WasNatlOrLocalElectionCandidate { get; }
        string NatlOrLocalElectionCandidacyDetails { get; }
        bool HasResignedForCandidacy { get; }
        string ResignationForCandidacyDetails { get; }
        bool HasAcquiredImmigrantStatus { get; }
        string OriginCountry { get; }
        bool IsIndigenousGroupMember { get; }
        string IndigenousGroupMembershipDetails { get; }
        bool IsDifferentlyAbled { get; }
        string DifferentlyAbledIdNumber { get; }
        bool IsSoloParent { get; }
        string SoloParentIdNumber { get; }
    }
}
