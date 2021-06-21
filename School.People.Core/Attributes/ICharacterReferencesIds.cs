using System;

namespace School.People.Core.Attributes
{
    public interface ICharacterReferencesIds : IAttribute
    {
        Guid? ReferenceA { get; }
        Guid? ReferenceB { get; }
        Guid? ReferenceC { get; }
    }
}
