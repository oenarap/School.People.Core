using System;
using School.People.Core.Attributes;

namespace School.People.Core.DTOs
{
    public class CharacterReferencesIds : Attribute, ICharacterReferencesIds
    {
        public Guid? ReferenceA { get; set; }
        public Guid? ReferenceB { get; set; }
        public Guid? ReferenceC { get; set; }

        public CharacterReferencesIds()
            : this(Guid.Empty) { }

        public CharacterReferencesIds(Guid id)
            : this(id, null, null, null) { }

        public CharacterReferencesIds(Guid id, Guid? referenceA, Guid? referenceB, Guid? referenceC)
        {
            Id = id;
            ReferenceA = referenceA;
            ReferenceB = referenceB;
            ReferenceC = referenceC;
        }
    }
}
