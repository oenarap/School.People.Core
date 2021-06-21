using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class AgencyMemberDetails : Attribute, IAgencyMemberDetails
    {
        public string AgencyId { get; set; }
        public string GsisIdNumber { get; set; }
        public string PagIbigIdNumber { get; set; }
        public string PhilhealthNumber { get; set; }
        public string SssNumber { get; set; }
        public string Tin { get; set; }

        public AgencyMemberDetails()
            : this(Guid.Empty) { }

        public AgencyMemberDetails(Guid id)
            : this(id, null, null, null, null, null, null) { }

        public AgencyMemberDetails(Guid id, string agencyId, string gsisIdNumber, string pagibigIdNumber,
            string philhealthIdNumber, string sssIdNumber, string taxIdNumber) {
            Id = id;
            AgencyId = agencyId;
            GsisIdNumber = gsisIdNumber;
            PagIbigIdNumber = pagibigIdNumber;
            PhilhealthNumber = philhealthIdNumber;
            SssNumber = sssIdNumber;
            Tin = taxIdNumber;
        }
    }
}
