using System;
using School.People.Core.Attributes;

namespace School.People.Core.Dtos
{
    public record CharacterReferencesIds : Attribute, ICharacterReferencesIds
    {
        public Guid? ReferenceA { get; init; }
        public Guid? ReferenceB { get; init; }
        public Guid? ReferenceC { get; init; }
    }
}
