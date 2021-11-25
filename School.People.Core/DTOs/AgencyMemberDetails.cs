using System;
using School.People.Core.Attributes;

namespace School.People.Core.Dtos
{
    public record AgencyMemberDetails : Attribute, IAgencyMemberDetails
    {
        public string AgencyId { get; init; }
        public string GsisIdNumber { get; init; }
        public string PagIbigIdNumber { get; init; }
        public string PhilhealthNumber { get; init; }
        public string SssNumber { get; init; }
        public string Tin { get; init; }
    }
}
