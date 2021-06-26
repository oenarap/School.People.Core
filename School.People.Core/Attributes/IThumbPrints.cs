using System;

namespace School.People.Core.Attributes
{
    public interface IThumbPrints : IAttribute
    {
        byte[] RightThumbmark { get; }
        byte[] LeftThumbmark { get; }
    }
}
