using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class IdPicture : Attribute, IIdPicture
    {
        public byte[] RecentPhoto { get; set; }

        public IdPicture()
            : this(Guid.Empty) { }

        public IdPicture(Guid id)
            : this(id, default) { }

        public IdPicture(Guid id, byte[] recentPhoto)
        {
            Id = id;
            RecentPhoto = recentPhoto;
        }
    }
}
