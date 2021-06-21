using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class Faqs : IFaqs
    {
        public Guid Id { get; set; }
        public bool IsRelatedToAuthorityThirdDegree { get; set; }
        public bool IsRelatedToAuthorityFourthDegree { get; set; }
        public string RelationshipToAuthorityDetails { get; set; }
        public bool IsGuiltyOfAdministrativeOffense { get; set; }
        public string AdministrativeOffenseDetails { get; set; }
        public bool WasCriminallyCharged { get; set; }
        public DateTimeOffset? CriminalChargesFilingDate { get; set; }
        public string CriminalChargesCaseStatus { get; set; }
        public bool WasConvicted { get; set; }
        public string ConvictionDetails { get; set; }
        public bool WasSeparatedFromService { get; set; }
        public string SeparationFromServiceDetails { get; set; }
        public bool WasNatlOrLocalElectionCandidate { get; set; }
        public string NatlOrLocalElectionCandidacyDetails { get; set; }
        public bool HasResignedForCandidacy { get; set; }
        public string ResignationForCandidacyDetails { get; set; }
        public bool HasAcquiredImmigrantStatus { get; set; }
        public string OriginCountry { get; set; }
        public bool IsIndigenousGroupMember { get; set; }
        public string IndigenousGroupMembershipDetails { get; set; }
        public bool IsDifferentlyAbled { get; set; }
        public string DifferentlyAbledIdNumber { get; set; }
        public bool IsSoloParent { get; set; }
        public string SoloParentIdNumber { get; set; }

        public Faqs()
            : this(Guid.Empty) { }

        public Faqs(Guid id)
            : this(id, false, false, null, false, null, false, null, null, false, null, false,
                null, false, null, false, null, false, null, false, null, false, null, false, null) { }

        public Faqs(Guid id, bool isRelatedToAuthorityThirdDegree, bool isRelatedToAuthorityFourthDegree, string relationshipToAuthorityDetails,
            bool isGuiltyOfAdministrativeOffense, string administrativeOffenseDetails, bool wasCriminallyCharged, DateTimeOffset? criminalChargesFilingDate,
            string criminalChargesCaseStatus, bool wasConvicted, string convictionDetails, bool wasSeparatedFromService, string separationFromServiceDetails,
            bool wasNatlOrLocalElectionCandidate, string natlOrLocalElectionCandidacyDetails, bool hasResignedForCandidacy, string resignationForCandidacyDetails,
            bool hasAcquiredImmigrantStatus, string originCountry, bool isIndigenousGroupMember, string indigenousGroupMembershipDetails, bool isDifferentlyAbled,
            string differentlyAbledIdNumber, bool isSoloParent, string soloParentIdNumber)
        {
            Id = id;
            IsRelatedToAuthorityThirdDegree = isRelatedToAuthorityThirdDegree;
            IsRelatedToAuthorityFourthDegree = isRelatedToAuthorityFourthDegree;
            RelationshipToAuthorityDetails = relationshipToAuthorityDetails;
            IsGuiltyOfAdministrativeOffense = isGuiltyOfAdministrativeOffense;
            AdministrativeOffenseDetails = administrativeOffenseDetails;
            WasCriminallyCharged = wasCriminallyCharged;
            CriminalChargesFilingDate = criminalChargesFilingDate;
            CriminalChargesCaseStatus = criminalChargesCaseStatus;
            WasConvicted = wasConvicted;
            ConvictionDetails = convictionDetails;
            WasSeparatedFromService = wasSeparatedFromService;
            SeparationFromServiceDetails = separationFromServiceDetails;
            WasNatlOrLocalElectionCandidate = wasNatlOrLocalElectionCandidate;
            NatlOrLocalElectionCandidacyDetails = natlOrLocalElectionCandidacyDetails;
            HasResignedForCandidacy = hasResignedForCandidacy;
            ResignationForCandidacyDetails = resignationForCandidacyDetails;
            HasAcquiredImmigrantStatus = hasAcquiredImmigrantStatus;
            OriginCountry = originCountry;
            IsIndigenousGroupMember = isIndigenousGroupMember;
            IndigenousGroupMembershipDetails = indigenousGroupMembershipDetails;
            IsDifferentlyAbled = isDifferentlyAbled;
            DifferentlyAbledIdNumber = differentlyAbledIdNumber;
            IsSoloParent = isSoloParent;
            SoloParentIdNumber = soloParentIdNumber;
        }
    }
}
