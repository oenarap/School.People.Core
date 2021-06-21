using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class Images : Attribute, IImage
    {
        public byte[] RecentPhoto { get; set; }

        public Images()
            : this(Guid.Empty) { }

        public Images(Guid id)
            : this(id, default) { }

        public Images(Guid id, byte[] recentPhoto)
        {
            Id = id;
            RecentPhoto = recentPhoto;
        }
    }
}
