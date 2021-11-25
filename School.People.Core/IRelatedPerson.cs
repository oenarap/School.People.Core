namespace School.People.Core
{
    public enum Relationship { Mother, Father, Spouse, Child }

    public interface IRelatedPerson : IPerson
    {
        Relationship Relationship { get; }
    }
}
