using System;
using School.People.Core.Attributes;

namespace School.People.Core.Dtos
{
    public record Faqs : Attribute, IFaqs
    {
        public bool IsRelatedToAuthorityThirdDegree { get; init; }
        public bool IsRelatedToAuthorityFourthDegree { get; init; }
        public string RelationshipToAuthorityDetails { get; init; }
        public bool IsGuiltyOfAdministrativeOffense { get; init; }
        public string AdministrativeOffenseDetails { get; init; }
        public bool WasCriminallyCharged { get; init; }
        public DateTimeOffset? CriminalChargesFilingDate { get; init; }
        public string CriminalChargesCaseStatus { get; init; }
        public bool WasConvicted { get; init; }
        public string ConvictionDetails { get; init; }
        public bool WasSeparatedFromService { get; init; }
        public string SeparationFromServiceDetails { get; init; }
        public bool WasNatlOrLocalElectionCandidate { get; init; }
        public string NatlOrLocalElectionCandidacyDetails { get; init; }
        public bool HasResignedForCandidacy { get; init; }
        public string ResignationForCandidacyDetails { get; init; }
        public bool HasAcquiredImmigrantStatus { get; init; }
        public string OriginCountry { get; init; }
        public bool IsIndigenousGroupMember { get; init; }
        public string IndigenousGroupMembershipDetails { get; init; }
        public bool IsDifferentlyAbled { get; init; }
        public string DifferentlyAbledIdNumber { get; init; }
        public bool IsSoloParent { get; init; }
        public string SoloParentIdNumber { get; init; }
    }
}
