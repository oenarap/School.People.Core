using System;

namespace School.People.Core.Attributes
{
    public interface IIdPicture : IAttribute
    {
        byte[] RecentPhoto { get; }
    }
}
