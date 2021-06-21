using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class Citizenship : Attribute, ICitizenship
    {
        public string DualCitizenshipMode { get; set; }
        public string DualCitizenship { get; set; }
        public string Country { get; set; }

        public Citizenship()
            : this(Guid.Empty) { }

        public Citizenship(Guid id)
            : this(id, null, null, null) { }

        public Citizenship(Guid id, string country, string dualCitizenship, string dualCitizenshipMode)
        {
            Id = id;
            Country = country;
            DualCitizenship = dualCitizenship;
            DualCitizenshipMode = dualCitizenshipMode;
        }
    }
}
