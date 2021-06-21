using System;

namespace School.People.Core.Attributes
{
    public interface IImage : IAttribute
    {
        byte[] ImageStream { get; }
        DateTimeOffset? DateUploaded { get; }
        Guid? UploadedBy { get; }
    }
}
