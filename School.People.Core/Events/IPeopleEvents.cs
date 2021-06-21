using Apps.Communication.Contracts;

namespace School.People.Core.Events
{
    public interface IOtherPersonArchivedEvent : IEvent<IPerson> { }
    public interface IPersonnelArchivedEvent : IEvent<IPerson> { }
    public interface IStudentArchivedEvent : IEvent<IPerson> { }
    public interface IStudentInsertedEvent : IEvent<IPerson> { }
    public interface IPersonnelInsertedEvent : IEvent<IPerson> { }
    public interface IOtherPersonInsertedEvent : IEvent<IPerson> { }
    public interface IStudentUpdatedEvent : IEvent<IPerson> { }
    public interface IPersonnelUpdatedEvent : IEvent<IPerson> { }
    public interface IOtherPersonUpdatedEvent : IEvent<IPerson> { }
}
