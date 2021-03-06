using System;
using School.People.Core.Attributes;

namespace School.People.Core.Dtos
{
    public record IdPicture : Attribute, IIdPicture
    {
        public byte[] RecentPhoto { get; init; }
    }
}
