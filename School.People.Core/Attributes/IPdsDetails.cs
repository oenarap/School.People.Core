using System;

namespace School.People.Core.Attributes
{
    public interface IPdsDetails : IAttribute
    {
        DateTimeOffset? DateAccomplished { get; }
    }
}
