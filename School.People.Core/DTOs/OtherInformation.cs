using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class OtherInformation : IndexedAttribute, IOtherInformation
    {
        public string Category { get; set; }
        public string DescriptiveName { get; set; }
        public string Details { get; set; }

        public OtherInformation()
            : this(Guid.Empty) { }

        public OtherInformation(Guid id)
            : this(id, Guid.Empty, null, null, null) { }

        public OtherInformation(Guid id, Guid index, string category, string descriptiveName, string details)
        {
            Id = id;
            Index = index;
            Category = category;
            DescriptiveName = descriptiveName;
            Details = details;
        }
    }
}
