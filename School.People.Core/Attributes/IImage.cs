using System;

namespace School.People.Core.Attributes
{
    public interface IImage : IAttribute
    {
        byte[] RecentPhoto { get; }
    }
}
